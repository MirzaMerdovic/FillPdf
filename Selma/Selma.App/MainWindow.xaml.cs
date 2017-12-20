using System.IO;
using System.Windows;
using System.Windows.Controls;
using Selma.App.Controls;
using Selma.Contracts.Entities;
using Selma.DataAccess;

namespace Selma.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly ICandidateInfoRepository _repository;

        public MainWindow()
        {
            InitializeComponent();

            _repository = new CandidateInfoRepository();
            InitializeDataStructure();
        }

        private void InitializeDataStructure()
        {
            TreeViewCandidates.Items.Clear();

            var candidatesPath = Helper.GetOrCreateDataPath();
            LoadTreeView(candidatesPath, TreeViewCandidates, _repository);
        }

        private void AddNewCandidate(object sender, RoutedEventArgs e)
        {
            var button = (Button) sender;
            var grid = (Grid)((Grid)GetWindow(button).Content).Children[1];

            grid.Children.Clear();
            grid.Children.Add(new AddCandidateControl { DataContext = new CandidateInfo()});
        }

        private static void LoadTreeView(string rootPath, ItemsControl root, ICandidateInfoRepository repository)
        {
            root.Items.Clear();

            var rootDirectory = new DirectoryInfo(rootPath);

            foreach (var directory in rootDirectory.GetDirectories("*", SearchOption.TopDirectoryOnly))
            {
                var item = new TreeViewItem { Name = $"ParentItem{directory.Name}", Header = directory.Name };
                root.Items.Add(item);

                LoadCandidates(item, directory, repository);
            }
        }

        private static void LoadCandidates(ItemsControl parent, FileSystemInfo parentDiectory, ICandidateInfoRepository repository)
        {
            foreach (var document in repository.GetAll(parentDiectory.FullName))
            {
                var item = new TreeViewItem
                {
                    Header = $"{document.LastName} {document.FirstName}",
                    DataContext = document
                };

                item.Selected += (sender, args) =>
                {
                    var tvi = (TreeViewItem)sender;
                    var grid = (Grid)((Grid)GetWindow(tvi).Content).Children[1];
                    grid.Children.Clear();

                    grid.Children.Add(new EditCandidateControl { DataContext = item.DataContext });
                };

                parent.Items.Add(item);
            }
        }

        private void ButtonRefresh_OnClick(object sender, RoutedEventArgs e)
        {
            InitializeDataStructure();
        }
    }
}
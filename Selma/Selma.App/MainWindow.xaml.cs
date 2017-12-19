using System.IO;
using System.Windows;
using System.Windows.Controls;
using Selma.App.Controls;
using Selma.App.Elements;
using Selma.DataAccess;

namespace Selma.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly CandidateDataRepository _repository;

        public MainWindow()
        {
            InitializeComponent();

            _repository = new CandidateDataRepository();
            InitializeDataStructure(_repository);
        }

        private void InitializeDataStructure(CandidateDataRepository repository)
        {
            var candidatesPath = Helper.GetOrCreateDataPath();
            LoadTreeView(candidatesPath, TreeViewCandidates, repository);
        }

        private static void LoadTreeView(string rootPath, ItemsControl root, CandidateDataRepository repository)
        {
            var rootDirectory = new DirectoryInfo(rootPath);

            foreach (var directory in rootDirectory.GetDirectories("*", SearchOption.TopDirectoryOnly))
            {
                var item = new TreeViewItem {Name = $"ParentItem{directory.Name}", Header = directory.Name};
                root.Items.Add(item);

                LoadCandidates(item, directory, repository);
            }
        }

        private static void LoadCandidates(ItemsControl parent, DirectoryInfo parentDiectory, CandidateDataRepository repository)
        {
            foreach (var document in repository.GetAll(parentDiectory.FullName))
            {
                var item = new TreeViewItem
                {
                    Header = $"{document.LastName} {document.FirstName}",
                    DataContext = document
                };

                item.Selected += ItemOnSelected;

                parent.Items.Add(item);
            }
        }

        private static void ItemOnSelected(object sender, RoutedEventArgs routedEventArgs)
        {
            var item = (TreeViewItem) sender;

            var grid = (Grid)((Grid)GetWindow(item).Content).Children[1];
            grid.Children.Clear();

            var candidateControl = new CandidateControl {DataContext = item.DataContext};
            grid.Children.Add(candidateControl);
        }

        private void AddNewCandidate(object sender, RoutedEventArgs e)
        {
            new AddCandidate().Show();
        }
    }
}
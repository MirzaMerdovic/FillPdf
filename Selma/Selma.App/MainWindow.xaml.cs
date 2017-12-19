using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Selma.App.Elements;

namespace Selma.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeDataStructure();
        }

        private void InitializeDataStructure()
        {
            var currentDirectory = new DirectoryInfo(Environment.CurrentDirectory);
            var rootPath = currentDirectory.Parent.Parent.FullName;

            var candidatesPath = Path.Combine(rootPath, @"Data\Candidates");

            if (!Directory.Exists(candidatesPath))
                Directory.CreateDirectory(candidatesPath);

            LoadTreeView(candidatesPath, TreeViewCandidates);
        }

        private static void LoadTreeView(string rootPath, ItemsControl root)
        {
            var rootDirectory = new DirectoryInfo(rootPath);

            foreach (var directory in rootDirectory.GetDirectories("*", SearchOption.TopDirectoryOnly))
            {
                var item = new TreeViewItem {Name = $"TreeViewItem{directory.Name}", Header = directory.Name};
                root.Items.Add(item);

                LoadCandidates(item, directory);
            }
        }

        private static void LoadCandidates(TreeViewItem parent, DirectoryInfo parentDiectory)
        {
            foreach (var candidate in parentDiectory.GetFiles("*.json", SearchOption.TopDirectoryOnly))
            {
                var item = new TreeViewItem {Header = candidate.Name.Replace(candidate.Extension, string.Empty)};
                parent.Items.Add(item);
            }
        }

        private void AddNewCandidate(object sender, RoutedEventArgs e)
        {
            new AddCandidate().Show();
        }
    }
}
using System;
using System.IO;
using System.Windows;

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

            if (!Directory.Exists(Path.Combine(rootPath, @"Data\Candidates")))
                Directory.CreateDirectory(Path.Combine(rootPath, @"Data\Candidates"));


        }
    }
}
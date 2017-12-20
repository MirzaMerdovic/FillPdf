using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Selma.Contracts.Entities;
using Selma.DataAccess;

namespace Selma.UI
{
    public partial class frmMain : Form
    {
        private readonly ICandidateInfoRepository _repository;
        public frmMain()
        {
            InitializeComponent();

            _repository = new CandidateInfoRepository();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            InitializeDataStructure();
        }

        private void InitializeDataStructure()
        {
            treeViewCandidates.ExpandAll();

            var candidatesPath = Helper.GetOrCreateDataPath();
            LoadTreeView(candidatesPath, treeViewCandidates, _repository);
        }

        private static void LoadTreeView(string rootPath, TreeView root, ICandidateInfoRepository repository)
        {
            root.Nodes.Clear();

            var rootDirectory = new DirectoryInfo(rootPath);

            foreach (var directory in rootDirectory.GetDirectories("*", SearchOption.TopDirectoryOnly))
            {
                var item = new TreeNode {Name = $"ParentItem{directory.Name}", Text = directory.Name, Tag = "parent"};
                root.Nodes.Add(item);

                LoadCandidates(item, directory, repository);
            }
        }

        private static void LoadCandidates(TreeNode parent, FileSystemInfo parentDiectory, ICandidateInfoRepository repository)
        {
            foreach (var document in repository.GetAll(parentDiectory.FullName))
            {
                var item = new TreeNode
                {
                    Text = $"{document.LastName} {document.FirstName}",
                    Tag = document
                };

                //item.Selected += (sender, args) =>
                //{
                //    var tvi = (TreeViewItem)sender;
                //    var grid = (Grid)((Grid)GetWindow(tvi).Content).Children[1];
                //    grid.Children.Clear();

                //    grid.Children.Add(new EditCandidateControl { DataContext = item.DataContext });
                //};

                parent.Nodes.Add(item);
            }
        }

        private void treeViewCandidates_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var node = e.Node;

            if(node.Tag?.ToString() != "parent")
                return;

            node.ExpandAll();
            dgvCandidates.Rows.Clear();

            foreach (TreeNode child in node.Nodes)
            {
                var info = (CandidateInfo)child.Tag;
             
                var index = dgvCandidates.Rows.Add(info.FirstName, info.LastName);
                dgvCandidates.Rows[index].Tag = info;
            }
        }

        private void dgvCandidates_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void dgvCandidates_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvCandidates.Rows[e.RowIndex];
        }
    }
}
using System.IO;
using System.Windows.Forms;
using Selma.DataAccess;

namespace Selma.UI
{
    public static class SharedViewLogic
    {
        public static void LoadTreeView(TreeView root, ICandidateInfoRepository repository)
        {
            root.Nodes.Clear();

            var rootDirectory = new DirectoryInfo(Helper.GetOrCreateDataPath());

            foreach (var directory in rootDirectory.GetDirectories("*", SearchOption.TopDirectoryOnly))
            {
                var item = new TreeNode { Name = $"ParentItem{directory.Name}", Text = directory.Name, Tag = "parent" };
                root.Nodes.Add(item);

                LoadCandidates(item, directory, repository);
            }

            root.ExpandAll();
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

                parent.Nodes.Add(item);
            }
        }
    }
}
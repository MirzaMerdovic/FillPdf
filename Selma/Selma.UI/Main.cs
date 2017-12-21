using System;
using System.IO;
using System.Windows.Forms;
using Selma.Contracts.Entities;
using Selma.DataAccess;
using Selma.UI.Windows;

namespace Selma.UI
{
    public partial class FrmMain : Form
    {
        private readonly ICandidateInfoRepository _repository;

        public FrmMain()
        {
            InitializeComponent();

            _repository = new CandidateInfoRepository();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SharedViewLogic.LoadTreeView(treeViewCandidates, _repository);
        }

        private void TreeViewCandidates_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
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

        private void DgvCandidates_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvCandidates.Rows[e.RowIndex];
            new AddOrUpdateForm(false, row.Tag as CandidateInfo, treeViewCandidates){Text = "Detalji o kandidatu"}.Show();
        }

        private void BtnAddCandidate_Click(object sender, EventArgs e)
        {
            new AddOrUpdateForm(true, new CandidateInfo(), treeViewCandidates) { Text = "Dodaj novog kandidata" }.Show();
        }
    }
}
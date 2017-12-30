using System;
using System.Windows.Forms;
using Selma.Contracts.Entities;
using Selma.DataAccess;
using Selma.UI.Windows;

namespace Selma.UI
{
    public partial class FrmMain : Form
    {
        private readonly ICandidateInfoRepository _candidateRepository;

        private readonly IInstructorRepository _instructorRepository;

        public FrmMain(ICandidateInfoRepository candidateRepository, IInstructorRepository instructorRepository)
        {
            InitializeComponent();

            _candidateRepository = candidateRepository;
            _instructorRepository = instructorRepository;
        }

        #region Form Events

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SharedViewLogic.LoadCandidatesTree(treeViewCandidates, _candidateRepository);
        }

        #endregion

        #region ToolStrip Events

        private void ToolBtnSettings_Click(object sender, EventArgs e)
        {
            new SettingsForm().Show();
        }

        private void ToolBtnInstructors_Click(object sender, EventArgs e)
        {
            new InstructorsForm(_instructorRepository).Show();
        }

        #endregion

        private void TreeViewCandidates_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var node = e.Node;

            if(node.Tag?.ToString() != "parent")
                return;

            node.ExpandAll();
            dgvCandidates.Rows.Clear();

            SharedViewLogic.LoadCandidatesGrid(dgvCandidates, node.Nodes);
        }

        private void DgvCandidates_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvCandidates.Rows[e.RowIndex];

            new AddOrUpdateForm(false, row.Tag as CandidateInfo, treeViewCandidates, dgvCandidates){Text = "Detalji o kandidatu"}.Show();
        }

        private void BtnAddCandidate_Click(object sender, EventArgs e)
        {
            new AddOrUpdateForm(true, new CandidateInfo(), treeViewCandidates, dgvCandidates) { Text = "Dodaj novog kandidata" }.Show();
        }
    }
}
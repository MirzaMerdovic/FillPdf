using iTextSharp.text;
using iTextSharp.text.pdf;
using Selma.Contracts.Entities;
using Selma.DataAccess;
using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.util;
using System.Windows.Forms;

namespace Selma.UI.Windows
{
    public partial class GenerateExamApplication : Form
    {
        private readonly CandidateInfo _info;
        private readonly ICandidateInfoRepository _repository;
        private readonly DataGridView _dgvCandidates;
        private readonly DataGridView _dgvExamHistory;
        private readonly TreeView _treeCandidates;

        public GenerateExamApplication(DataGridView dgvCandidates, DataGridView dgvExamHistory, TreeView treeCandidates)
        {
            _dgvCandidates = dgvCandidates;
            _dgvExamHistory = dgvExamHistory;
            _treeCandidates = treeCandidates;

            InitializeComponent();
        }

        public GenerateExamApplication(CandidateInfo info, ICandidateInfoRepository repository, DataGridView dgvCandidates, DataGridView dgvExamHistory, TreeView treeCandidates) 
            : this(dgvCandidates, dgvExamHistory, treeCandidates)
        {
            _info = info;
            _repository = repository;
        }

        private void GenerateExamApplication_Load(object sender, EventArgs e)
        {
            lblCandidateInfo.Text = $"{lblCandidateInfo.Text} {_info.FirstName} {_info.LastName}";
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            var info = _repository.Get(_info.FirstName, _info.LastName);

            if (info == null)
            {
                Helper.Logger.Error($"Podaci o kandidatu: {_info.FirstName} {_info.LastName} ne mogu biti nadjeni");
                MessageBox.Show($"Podaci o kandidatu: {_info.FirstName} {_info.LastName} ne mogu biti nadjeni");
                Close();

                return;
            }

            var exam = new ExamInfo
            {
                Id = Guid.NewGuid().ToString("N"),
                Category = txtCategory.Text.Trim(),
                TakenOn = dtpTakenOn.Value,
                IncludesTrafficRegulationsTest = chxIncludesTrafficRegulationTest.Checked,
                IncludesFirstAidTest = chxIncludesFirstAidTest.Checked,
                IncludesDrivingTest = chxIncludesDrivingTest.Checked
            };

            info.Exams.Add(exam);

            Helper.CreateExamForm(Helper.GetPdfTemplateLocation(), _info, exam);

            _repository.Update(info);


            SharedViewLogic.LoadCandidatesTree(_treeCandidates, _repository);

            var selectedNode = _treeCandidates.Nodes.Find(info.LastName.First().ToString(), false).FirstOrDefault();
            SharedViewLogic.LoadCandidatesGrid(_dgvCandidates, selectedNode?.Nodes ?? (IEnumerable) Enumerable.Empty<TreeNode>());

            SharedViewLogic.LoadExamHistory(info.Exams ?? Enumerable.Empty<ExamInfo>(), _dgvExamHistory);
            Close();
        }
    }
}

using Selma.Contracts.Entities;
using Selma.DataAccess;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace Selma.UI.Windows
{
    public partial class GenerateExamApplication : Form
    {
        private readonly CandidateInfo _info;
        private readonly ICandidateInfoRepository _candidateRepository;
        private readonly IInstructorRepository _instructorRepository;
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

        public GenerateExamApplication(CandidateInfo info, ICandidateInfoRepository candidateRepository, IInstructorRepository instructorRepository, DataGridView dgvCandidates, DataGridView dgvExamHistory, TreeView treeCandidates) 
            : this(dgvCandidates, dgvExamHistory, treeCandidates)
        {
            _info = info;
            _candidateRepository = candidateRepository;
            _instructorRepository = instructorRepository;
        }

        private void GenerateExamApplication_Load(object sender, EventArgs e)
        {
            lblCandidateInfo.Text = $"{lblCandidateInfo.Text} {_info.FirstName} {_info.LastName}";
            cbxExamDay.SelectedIndex = 0;

            object[] items = _instructorRepository.GetAll().Select(x => $"{x.FirstName} {x.LastName}").ToArray();
            if (!items.Any())
                return;

            cbxInstructors.Items.AddRange(items);
            cbxInstructors.SelectedIndex = 0;
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            var info = _candidateRepository.Get(_info.FirstName, _info.LastName);

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
                IncludesDrivingTest = chxIncludesDrivingTest.Checked,
                Day = cbxExamDay.SelectedItem.ToString(),
                Location = txtLocation.Text.Trim(),
                Instructor = _instructorRepository.Get(cbxInstructors.SelectedItem.ToString())
            };

            info.Exams.Add(exam);

            Helper.CreateExamForm(Helper.GetPdfTemplateLocation(), _info, exam);

            _candidateRepository.Update(info);


            SharedViewLogic.LoadCandidatesTree(_treeCandidates, _candidateRepository);

            var selectedNode = _treeCandidates.Nodes.Find(info.LastName.First().ToString(), false).FirstOrDefault();
            SharedViewLogic.LoadCandidatesGrid(_dgvCandidates, selectedNode?.Nodes ?? (IEnumerable) Enumerable.Empty<TreeNode>());
            SharedViewLogic.LoadExamHistory(info.Exams ?? Enumerable.Empty<ExamInfo>(), _dgvExamHistory);

            Close();
        }
    }
}

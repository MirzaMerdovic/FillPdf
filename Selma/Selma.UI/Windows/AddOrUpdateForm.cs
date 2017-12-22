using Selma.Contracts.Entities;
using Selma.DataAccess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Selma.UI.Windows
{
    public partial class AddOrUpdateForm : Form
    {
        #region Fields

        private CandidateInfo _info;
        private TreeView _treeView;
        private readonly ICandidateInfoRepository _repository;

        #endregion

        #region Constructors

        public AddOrUpdateForm()
        {
            InitializeComponent();

            _repository = new CandidateInfoRepository();
        }

        public AddOrUpdateForm(bool isAdd, CandidateInfo info, TreeView treeView) : this()
        {
            SetButtons(isAdd);

            _info = info;
            _treeView = treeView;
        }

        #endregion

        #region Form Events

        private void AddOrUpdateForm_Load(object sender, EventArgs e)
        {
            BindValues(_info);
        }

        private void AddOrUpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SharedViewLogic.LoadTreeView(_treeView, _repository);
        }

        #endregion

        #region Button Events

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var info = GetCandidateInfo();
            _repository.Create(info);
            
            Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var info = GetCandidateInfo();
            _repository.Update(info);
            
            Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _repository.Delete(txtFirstName.Text.Trim(), txtLastName.Text.Trim());

            Close();
        }

        private void BtnPrintExam_Click(object sender, EventArgs e)
        {
            var templatePath = Helper.GetPdfTemplateLocation();

            if (!File.Exists(templatePath))
                MessageBox.Show($"Prazna PDF Prijava mora postajati na lokaciji: {templatePath}");
            else
            {
                var info = GetCandidateInfo();
                new GenerateExamApplication(info, _repository).Show();
            }
        }

        #endregion

        #region DatagridView Events

        private void DgvExamHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = dgvExamHistory.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var selectedRow = dgvExamHistory.Rows[e.RowIndex];

            if (e.ColumnIndex == 5)
            {
                var selectedExam = selectedRow.Tag as ExamInfo;
                
                // TODO: Print exam application
                return;
            }

            if (e.ColumnIndex == 6)
            {
                dgvExamHistory.Rows.Remove(selectedRow);
            }
        }

        #endregion

        #region Helpers

        private void SetButtons(bool isAdd)
        {
            if (isAdd)
            {
                btnDelete.Visible = btnDelete.Enabled = btnEdit.Visible = btnEdit.Enabled = false;
                btnAdd.Visible = btnAdd.Enabled = true;
            }
            else
            {
                btnDelete.Visible = btnDelete.Enabled = btnEdit.Visible = btnEdit.Enabled = true;
                btnAdd.Visible = btnAdd.Enabled = false;
            }
        }

        private void BindValues(CandidateInfo info)
        {
            txtFirstName.Text = info.FirstName;
            txtLastName.Text = info.LastName;
            txtNameOfParent.Text = info.NameOfParent;
            txtJmbg.Text = info.Jmbg;
            txtAddress.Text = info.Address;
            txtPhone.Text = info.Phone;
            txtPostalCode.Text = info.PostalCode;
            txtCity.Text = info.City;
            txtCitizenship.Text = info.Citizenship;
            txtOccupancy.Text = info.Occupancy;

            txtDrivingLicenceId.Text = info.DrivingLicence?.LicenceId;
            txtCategory.Text = info.DrivingLicence?.Category;
            txtNotes.Text = info.DrivingLicence?.Notes;

            if (info.DrivingLicence != null)
                dtpIssueOn.Value = info.DrivingLicence.IssuedOn;

            if (info.DrivingLicence != null)
                dtpExpiresOn.Value = info.DrivingLicence.ExpiresOn;


            foreach (var exam in info.Exams)
            {
                var index = dgvExamHistory.Rows.Add(
                    exam.Category,
                    exam.TakenOn.Date.ToShortDateString(),
                    exam.IncludesTrafficRegulationsTest,
                    exam.IncludesFirstAidTest,
                    exam.IncludesDrivingTest);

                dgvExamHistory.Rows[index].Tag = exam;
                dgvExamHistory.Rows[index].Cells["clmPrint"].Value = "Print";

                dgvExamHistory.Rows[index].Tag = exam;
                dgvExamHistory.Rows[index].Cells["clmDelete"].Value = "Obrisi";
            }
        }

        private CandidateInfo GetCandidateInfo()
        {
            return new CandidateInfo
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                NameOfParent = txtNameOfParent.Text.Trim(),
                Jmbg = txtJmbg.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                PostalCode = txtPostalCode.Text.Trim(),
                City = txtCity.Text.Trim(),
                Citizenship = txtCitizenship.Text.Trim(),
                Occupancy = txtOccupancy.Text.Trim(),
                DrivingLicence = new DrivingLicenceInfo
                {
                    LicenceId = txtDrivingLicenceId.Text.Trim(),
                    Category = txtCategory.Text.Trim(),
                    IssuedOn = dtpIssueOn.Value,
                    ExpiresOn = dtpExpiresOn.Value,
                    Notes = txtNotes.Text.Trim()
                },
               Exams = GetExams(dgvExamHistory.Rows)
            };
        }

        private static ICollection<ExamInfo> GetExams(DataGridViewRowCollection rows)
        {
            var exams = new List<ExamInfo>();

            foreach (DataGridViewRow row in rows)
            {
                var exam = row.Tag as ExamInfo;

                if (exam == null)
                    continue;

                exams.Add(exam);
            }

            return exams;
        }

        #endregion
    }
}

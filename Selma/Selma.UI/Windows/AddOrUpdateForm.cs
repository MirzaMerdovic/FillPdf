using Selma.Contracts.Entities;
using Selma.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Selma.UI.Windows
{
    public partial class AddOrUpdateForm : Form
    {
        #region Fields

        private readonly CandidateInfo _info;
        private readonly TreeView _treeView;
        private readonly DataGridView _dgvCandidates;
        private readonly ICandidateInfoRepository _repository;

        #endregion

        #region Constructors

        public AddOrUpdateForm()
        {
            InitializeComponent();

            _repository = new CandidateInfoRepository();
        }

        public AddOrUpdateForm(bool isAdd, CandidateInfo info, TreeView treeView, DataGridView dgvCandidates) : this()
        {
            SetButtons(isAdd);

            _info = info;
            _treeView = treeView;
            _dgvCandidates = dgvCandidates;
        }

        #endregion

        #region Form Events

        private void AddOrUpdateForm_Load(object sender, EventArgs e)
        {
            BindValues(_info);
        }

        private void AddOrUpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SharedViewLogic.LoadCandidatesTree(_treeView, _repository);
        }

        #endregion

        #region Button Events

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var info = GetCandidateInfo();
            _repository.Create(info);

            SharedViewLogic.LoadCandidatesTree(_treeView, _repository);

            var selectedNode = GetOrAddParentNode(info);
            SharedViewLogic.LoadCandidatesGrid(_dgvCandidates, selectedNode.Nodes);

            Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var info = GetCandidateInfo();
            _repository.Update(info);

            SharedViewLogic.LoadCandidatesTree(_treeView, _repository);

            if (_dgvCandidates.SelectedRows.Count > 0)
                _dgvCandidates.SelectedRows[0].Tag = info;

            Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _repository.Delete(txtFirstName.Text.Trim(), txtLastName.Text.Trim());

            SharedViewLogic.LoadCandidatesTree(_treeView, _repository);

            var parentNode = _treeView.Nodes.Find(_info.LastName.First().ToString(), false).FirstOrDefault();
            SharedViewLogic.LoadCandidatesGrid(_dgvCandidates, parentNode?.Nodes ?? (IEnumerable)Enumerable.Empty<TreeNode>());

            Close();
        }

        private void BtnPrintExam_Click(object sender, EventArgs e)
        {
            var templatePath = Helper.GetPdfTemplateLocation();

            if (!File.Exists(templatePath))
            {
                Helper.Logger.Warn($"PDF Application template doesn't exist. Location: {templatePath}");
                MessageBox.Show($"Prazna PDF Prijava mora postajati na lokaciji: {templatePath}");
            }
            else
            {
                var info = GetCandidateInfo();
                new GenerateExamApplication(info, _repository, _dgvCandidates, dgvExamHistory, _treeView).Show();
            }
        }

        #endregion

        #region DatagridView Events

        private void DgvExamHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgvExamHistory.Rows[e.RowIndex];

            // Open the file.
            if (e.ColumnIndex == 5)
            {
                if (!(selectedRow.Tag is ExamInfo selectedExam))
                    return;

                var path = Helper.CreateExamForm(Helper.GetPdfTemplateLocation(), _info, selectedExam);
                Process.Start(path);

                return;
            }

            // Remove from grid view.
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


            SharedViewLogic.LoadExamHistory(info.Exams ?? Enumerable.Empty<ExamInfo>(), dgvExamHistory);
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

        private static ICollection<ExamInfo> GetExams(IEnumerable rows)
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

        private TreeNode GetOrAddParentNode(CandidateInfo info)
        {
            var selectedNode = _treeView.Nodes.Find(info.LastName.First().ToString(), false).FirstOrDefault();

            if (selectedNode != null)
                return selectedNode;

            var index = _treeView.Nodes.Add(
                new TreeNode
                {
                    Name = info.LastName.First().ToString(),
                    Text = info.LastName.First().ToString(),
                    Tag = "parent",
                    Nodes =
                    {
                        new TreeNode
                        {
                            Name = $"{info.LastName} {info.FirstName}",
                            Text = $"{info.LastName} {info.FirstName}",
                            Tag = info
                        }
                    }
                });

            selectedNode = _treeView.Nodes[index];

            return selectedNode;
        }

        #endregion
    }
}
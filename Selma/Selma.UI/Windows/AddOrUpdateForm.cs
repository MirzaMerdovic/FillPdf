using Selma.Contracts.Entities;
using Selma.DataAccess;
using System;
using System.IO;
using System.Windows.Forms;

namespace Selma.UI.Windows
{
    public partial class AddOrUpdateForm : Form
    {
        private CandidateInfo _info;
        private TreeView _treeView;
        private readonly ICandidateInfoRepository _repository;

        public AddOrUpdateForm()
        {
            InitializeComponent();

            _repository = new CandidateInfoRepository();
        }

        public AddOrUpdateForm(bool isAdd, CandidateInfo info, TreeView treeView) : this()
        {
            if (isAdd)
            {
                btnDelete.Visible = false;
                btnDelete.Enabled = false;
                btnEdit.Visible = false;
                btnEdit.Enabled = false;
                btnAdd.Visible = true;
                btnAdd.Enabled = true;
            }
            else
            {
                btnDelete.Visible = true;
                btnDelete.Enabled = true;
                btnEdit.Visible = true;
                btnEdit.Enabled = true;
                btnAdd.Visible = false;
                btnAdd.Enabled = false;
            }

            _info = info;
            _treeView = treeView;
        }

        private void AddOrUpdateForm_Load(object sender, EventArgs e)
        {
            BindValues(_info);
        }

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

        private void AddOrUpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SharedViewLogic.LoadTreeView(_treeView, _repository);
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
                }
            };
        }
    }
}

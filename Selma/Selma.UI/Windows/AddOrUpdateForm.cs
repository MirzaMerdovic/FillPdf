using Selma.Contracts.Entities;
using Selma.DataAccess;
using System;
using System.Windows.Forms;

namespace Selma.UI.Windows
{
    public partial class AddOrUpdateForm : Form
    {
        private CandidateInfo _info;
        private DataGridView _candidatesView;
        private readonly ICandidateInfoRepository _repository;

        public AddOrUpdateForm()
        {
            InitializeComponent();

            _repository = new CandidateInfoRepository();
        }

        public AddOrUpdateForm(bool isAdd, CandidateInfo info, DataGridView gridView) : this()
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
            _candidatesView = gridView;
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
            txtAddress.Text = info.Address;
            txtPhone.Text = info.Phone;
            txtPostalCode.Text = info.PostalCode;
            txtCity.Text = info.City;
            txtCitizenship.Text = info.Citizenship;

            txtDrivingLicenceId.Text = info.DrivingLicence?.LicenceId;
            txtCategory.Text = info.DrivingLicence?.Category;

            if (info.DrivingLicence != null)
                dtpIssueOn.Value = info.DrivingLicence.IssuedOn;

            if (info.DrivingLicence != null)
                dtpExpiresOn.Value = info.DrivingLicence.ExpiresOn;
        }

        private CandidateInfo GetCandidateInfo()
        {
            return new CandidateInfo
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                PostalCode = txtPostalCode.Text.Trim(),
                City = txtCity.Text.Trim(),
                Citizenship = txtCitizenship.Text.Trim(),
                DrivingLicence = new DrivingLicenceInfo
                {
                    LicenceId = txtDrivingLicenceId.Text.Trim(),
                    Category = txtCategory.Text.Trim(),
                    IssuedOn = dtpIssueOn.Value,
                    ExpiresOn = dtpExpiresOn.Value
                }
            };
        }
    }
}

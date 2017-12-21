using Selma.Contracts.Entities;
using Selma.DataAccess;
using System;
using System.IO;
using System.util;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

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

            SharedViewLogic.LoadTreeView(_treeView, _repository);
            Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var info = GetCandidateInfo();
            _repository.Update(info);

            SharedViewLogic.LoadTreeView(_treeView, _repository);
            Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _repository.Delete(txtFirstName.Text.Trim(), txtLastName.Text.Trim());

            SharedViewLogic.LoadTreeView(_treeView, _repository);
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

        private void BtnPrintExam_Click(object sender, EventArgs e)
        {
            var templatePath = Helper.GetPdfTemplateLocation();

            if (!File.Exists(templatePath))
                MessageBox.Show($"Prazna PDF Prijava mora postajati na lokaciji: {templatePath}");
            else
            {
                var info = GetCandidateInfo();
                CreateExamForm(templatePath, info);
            }
        }

        private void CreateExamForm(string templatePath, CandidateInfo info)
        {
            var reader = new PdfReader(templatePath);
            var stamper = new PdfStamper(reader, new FileStream(Path.Combine(Helper.GetTempFolder(), $"{info.LastName} {info.FirstName}.pdf"), FileMode.Create));

            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 570, 120, 12)), "CandidateFullName", $"{info.LastName} {info.FirstName}").GetTextField(), 1);
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 554, 120, 12)), "CandidateParentName", info.NameOfParent).GetTextField(), 1);
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 538, 120, 12)), "CandidateBirthDayAndDate", $"{info.BirthDate} {info.City}").GetTextField(), 1);
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 524, 120, 12)), "CandidateJmbg", info.Jmbg).GetTextField(), 1);
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 508, 120, 12)), "CandidateCitizenship", info.Citizenship).GetTextField(), 1);
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 492, 120, 12)), "CandidateOccupancy", info.Occupancy).GetTextField(), 1);
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 476, 120, 12)), "CandidateAddress", $"{info.Address} {info.PostalCode} {info.City}").GetTextField(), 1);
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 460, 120, 12)), "CandidateDrivingLicenceCategory", "B").GetTextField(), 1);
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 444, 120, 12)), "CandidateDrivingSchoolName", Helper.GetSchoolName()).GetTextField(), 1);
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 428, 120, 12)), "CandidateExamCount", "1").GetTextField(), 1);
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 414, 120, 12)), "CandidateHasDrivingLicence", info.DrivingLicence == null ? "Nema" : $"{info.DrivingLicence.Category}, {info.DrivingLicence.LicenceId}, {info.DrivingLicence.IssuedOn.ToShortDateString()}").GetTextField(), 1);
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 400, 120, 12)), "CandidateCanHaveDrivingLicence", info.Notes).GetTextField(), 1);
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(110, 69, 40, 12)), "CandidateDayAndMonth", $"{DateTime.Now.Day}.{DateTime.Now.Month}").GetTextField(), 1);
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(185, 69, 40, 12)), "CandidateYear", DateTime.Now.Year.ToString().Substring(2, 2)).GetTextField(), 1);

            stamper.FormFlattening = true;
            stamper.Close();
        }

        private static TextField Create(PdfWriter writer, Rectangle rectangle, string fieldName, string value)
        {
            return new TextField(writer, rectangle, fieldName)
            {
                Text = value,
                Options = BaseField.VISIBLE & BaseField.READ_ONLY,
                Font = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, false)
            };
        }
    }
}

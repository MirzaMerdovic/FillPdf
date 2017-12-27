using iTextSharp.text;
using iTextSharp.text.pdf;
using Selma.Contracts.Entities;
using Selma.DataAccess;
using System;
using System.IO;
using System.util;
using System.Windows.Forms;

namespace Selma.UI.Windows
{
    public partial class GenerateExamApplication : Form
    {
        private readonly CandidateInfo _info;
        private readonly ICandidateInfoRepository _repository;

        public GenerateExamApplication()
        {
            InitializeComponent();
        }

        public GenerateExamApplication(CandidateInfo info, ICandidateInfoRepository repository) : this()
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
            var path = CreateExamForm(Helper.GetPdfTemplateLocation(), _info);

            var info = _repository.Get(_info.FirstName, _info.LastName);

            if (info == null)
            {
                Helper.Logger.Error($"Podaci o kandidatu: {_info.FirstName} {_info.LastName} ne mogu biti nadjeni");
                MessageBox.Show($"Podaci o kandidatu: {_info.FirstName} {_info.LastName} ne mogu biti nadjeni");
                Close();

                return;
            }

            info.Exams.Add(new ExamInfo
            {
                Category = txtCategory.Text.Trim(),
                TakenOn = dtpTakenOn.Value,
                IncludesTrafficRegulationsTest = chxIncludesTrafficRegulationTest.Checked,
                IncludesFirstAidTest = chxIncludesFirstAidTest.Checked,
                IncludesDrivingTest = chxIncludesDrivingTest.Checked,
                Path = path
            });

            _repository.Update(info);

            Close();
        }

        private string CreateExamForm(string templatePath, CandidateInfo info)
        {
            try
            {
                var path = Path.Combine(Helper.GetExamApplicationsFolder(), $"{info.LastName} {info.FirstName}_{dtpTakenOn.Value.Ticks}.pdf");
                var reader = new PdfReader(templatePath);
                var stamper = new PdfStamper(reader, new FileStream(path, FileMode.Create));

                if (chxIncludesTrafficRegulationTest.Checked)
                    stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(28, 648, 12, 12)), "IncludeTrafficRegulations", "X").GetTextField(), 1);

                if (chxIncludesFirstAidTest.Checked)
                    stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(28, 634, 12, 12)), "IncludeFirstAid", "X").GetTextField(), 1);

                if (chxIncludesDrivingTest.Checked)
                    stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(28, 620, 12, 12)), "IncludeDriving", "X").GetTextField(), 1);

                stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 570, 120, 12)), "CandidateFullName", $"{info.LastName} {info.FirstName}").GetTextField(), 1);
                stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 554, 120, 12)), "CandidateParentName", info.NameOfParent).GetTextField(), 1);
                stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 538, 120, 12)), "CandidateBirthDayAndDate", $"{info.BirthDate.ToShortDateString()} {info.City}").GetTextField(), 1);
                stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 524, 120, 12)), "CandidateJmbg", info.Jmbg).GetTextField(), 1);
                stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 508, 120, 12)), "CandidateCitizenship", info.Citizenship).GetTextField(), 1);
                stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 492, 120, 12)), "CandidateOccupancy", info.Occupancy).GetTextField(), 1);
                stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 476, 120, 12)), "CandidateAddress", $"{info.Address} {info.PostalCode} {info.City}").GetTextField(), 1);
                stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 460, 120, 12)), "CandidateDrivingLicenceCategory", txtCategory.Text.Trim()).GetTextField(), 1);
                stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 444, 120, 12)), "CandidateDrivingSchoolName", Helper.GetSchoolName()).GetTextField(), 1);
                stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 428, 120, 12)), "CandidateExamCount", $"{info.Exams.Count + 1}").GetTextField(), 1);
                stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 414, 120, 12)), "CandidateHasDrivingLicence", string.IsNullOrWhiteSpace(info.DrivingLicence.LicenceId) ? "Nema" : $"{info.DrivingLicence.Category}, {info.DrivingLicence.LicenceId}, {info.DrivingLicence.IssuedOn.ToShortDateString()}").GetTextField(), 1);
                stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 400, 120, 12)), "CandidateCanHaveDrivingLicence", info.DrivingLicence?.Notes).GetTextField(), 1);
                stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(110, 69, 40, 12)), "CandidateDayAndMonth", $"{DateTime.Now.Day}.{DateTime.Now.Month}").GetTextField(), 1);
                stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(185, 69, 40, 12)), "CandidateYear", DateTime.Now.Year.ToString().Substring(2, 2)).GetTextField(), 1);

                stamper.FormFlattening = true;
                stamper.Close();

                return path;
            }
            catch (Exception e)
            {
                Helper.Logger.Error($"Method: CreateExamForm, {Environment.NewLine} Error: {e.Message}, {Environment.NewLine}{e}");
            }

            return string.Empty;
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

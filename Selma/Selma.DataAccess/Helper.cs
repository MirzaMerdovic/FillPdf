using System;
using System.Configuration;
using System.IO;
using System.Text;
using System.util;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using NLog;
using Selma.Contracts.Entities;

namespace Selma.DataAccess
{
    public static class Helper
    {
        public static readonly ILogger Logger = LogManager.GetLogger("selma");

        public static string GetDataPath()
        {
            var dataPath = ConfigurationManager.AppSettings["DataPath"];

            return dataPath;
        }

        public static string GetPdfTemplateLocation()
        {
            var templateLocation = Path.Combine(GetDataPath(), @"Prazna.pdf");

            return templateLocation;
        }

        public static string GetExamApplicationsFolder()
        {
            var tempPath = Path.Combine(GetDataPath(), @"Prijave");

            if (!Directory.Exists(tempPath))
                Directory.CreateDirectory(tempPath);

            return tempPath;
        }

        public static string GetOrCreateCandidatePath()
        {
            var rootPath = GetDataPath();
            var candidatesPath = Path.Combine(rootPath, @"Kandidati");

            if (!Directory.Exists(candidatesPath))
                Directory.CreateDirectory(candidatesPath);

            return candidatesPath;
        }

        public static string GetOrCreateInstructorsPath()
        {
            var rootPath = GetDataPath();
            var instructorsPath = Path.Combine(rootPath, @"Instruktori");

            if (!Directory.Exists(instructorsPath))
                Directory.CreateDirectory(instructorsPath);

            return instructorsPath;
        }

        public static string GetOrCreateParentPath(string parentFolderName)
        {
            var parentPath = Path.Combine(GetOrCreateCandidatePath(), parentFolderName);

            if (!Directory.Exists(parentPath))
                Directory.CreateDirectory(parentPath);

            return parentPath;
        }

        public static void SaveJson(string path, object data)
        {
            var json = JsonConvert.SerializeObject(data, Formatting.Indented);

            File.WriteAllText(path, json, Encoding.GetEncoding("ISO-8859-2"));
        }

        public static string ReadJson(string jsonPath)
        {
            return File.ReadAllText(jsonPath, Encoding.GetEncoding("ISO-8859-2"));
        }

        public static string GetSchoolName()
        {
            return ConfigurationManager.AppSettings["SchoolName"] ?? "Selma";
        }

        public static string CreateExamForm(string templatePath, CandidateInfo info, ExamInfo exam)
        {
            try
            {
                var path = Path.Combine(Helper.GetExamApplicationsFolder(), $"{info.LastName} {info.FirstName}_{exam.TakenOn.Ticks}.pdf");
                var reader = new PdfReader(templatePath);

                try
                {
                    using (var stamper = new PdfStamper(reader, new FileStream(path, FileMode.Create)))
                    {
                        reader = null;
                        if (exam.IncludesTrafficRegulationsTest)
                            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(28, 648, 12, 12)), "IncludeTrafficRegulations", "X").GetTextField(), 1);

                        if (exam.IncludesFirstAidTest)
                            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(28, 634, 12, 12)), "IncludeFirstAid", "X").GetTextField(), 1);

                        if (exam.IncludesDrivingTest)
                            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(28, 620, 12, 12)), "IncludeDriving", "X").GetTextField(), 1);

                        stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(240, 618, 50, 12)), "ExamLocation", exam.Location).GetTextField(), 1);
                        stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(300, 618, 50, 12)), "ExamDay", exam.Day).GetTextField(), 1);
                        stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(380, 618, 80, 12)), "InstructorName", $"ins. {exam.Instructor?.LastName} {exam.Instructor?.FirstName}").GetTextField(), 1);
                        stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(394, 604, 50, 12)), "InstructorPhoner", exam.Instructor?.Phone).GetTextField(), 1);

                        stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 570, 120, 12)), "CandidateFullName", $"{info.LastName} {info.FirstName}").GetTextField(), 1);
                        stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 554, 120, 12)), "CandidateParentName", info.NameOfParent).GetTextField(), 1);
                        stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 538, 120, 12)), "CandidateBirthDayAndDate", $"{info.BirthDate.ToShortDateString()} {info.City}").GetTextField(), 1);
                        stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 524, 120, 12)), "CandidateJmbg", info.Jmbg).GetTextField(), 1);
                        stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 508, 120, 12)), "CandidateCitizenship", info.Citizenship).GetTextField(), 1);
                        stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 492, 120, 12)), "CandidateOccupancy", info.Occupancy).GetTextField(), 1);
                        stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 476, 120, 12)), "CandidateAddress", $"{info.Address} {info.PostalCode} {info.City}").GetTextField(), 1);
                        stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 460, 120, 12)), "CandidateDrivingLicenceCategory", exam.Category.Trim()).GetTextField(), 1);
                        stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 444, 120, 12)), "CandidateDrivingSchoolName", Helper.GetSchoolName()).GetTextField(), 1);
                        stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 428, 120, 12)), "CandidateExamCount", $"{info.Exams.Count + 1}").GetTextField(), 1);
                        stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 414, 120, 12)), "CandidateHasDrivingLicence", string.IsNullOrWhiteSpace(info.DrivingLicence.LicenceId) ? "Nema" : $"{info.DrivingLicence.Category}, {info.DrivingLicence.LicenceId}, {info.DrivingLicence.IssuedOn.ToShortDateString()}").GetTextField(), 1);
                        stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 400, 120, 12)), "CandidateCanHaveDrivingLicence", info.DrivingLicence?.Notes).GetTextField(), 1);
                        stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(110, 69, 40, 12)), "CandidateDayAndMonth", $"{exam.TakenOn.Day}.{exam.TakenOn.Month}").GetTextField(), 1);
                        stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(185, 69, 40, 12)), "CandidateYear", exam.TakenOn.Year.ToString().Substring(2, 2)).GetTextField(), 1);

                        stamper.FormFlattening = true;
                    }
                }
                finally
                {
                    reader?.Dispose();
                }

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
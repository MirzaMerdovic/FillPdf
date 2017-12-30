using System;
using System.IO;
using System.util;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selma.Contracts.Entities;
using Selma.DataAccess;

namespace Selma.Test
{
    [TestClass]
    public class PdfTests
    {
        public static string PdfFileLocation = @"C:\Users\mirza\Source\Repos\FillPdf\Selma\Selma.Test\Prazna.pdf";

        [TestMethod]
        public void ShouldGeneratePdfApplication()
        {
            var path = Helper.CreateExamForm(PdfFileLocation, new CandidateInfo
            {
                FirstName = "Mirza",
                LastName = "Merdović",
                Address = "Aleja Lipa 13",
                BirthDate = new DateTime(1984, 10, 1),
                Citizenship = "BiH",
                City = "Sarajevo",
                Jmbg = "0110984555666",
                NameOfParent = "Dedo",
                Occupancy = "Softver developer",
                Phone = "063 002 111",
                PostalCode = "71000",
                DrivingLicence = new DrivingLicenceInfo
                {
                    IssuedOn = new DateTime(2017, 12, 28),
                    ExpiresOn = new DateTime(2022, 12, 28),
                    Category = "B",
                    LicenceId = "234U567I9",
                    Notes = "Nema"
                }
            },
            new ExamInfo
            {
                TakenOn = DateTime.UtcNow.AddDays(12),
                Category = "C",
                IncludesDrivingTest = true,
                IncludesFirstAidTest = false,
                IncludesTrafficRegulationsTest = false,
                Location = "Grbavica",
                Day = "Subota",
                Instructor = new Instructor
                {
                    FirstName = "Nezir",
                    LastName = "Mehić",
                    Phone = "062 334 125"
                }
            });

            Assert.IsTrue(File.Exists(path));
        }
    }
}

using System.IO;
using System.util;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Selma.Test
{
    [TestClass]
    public class UnitTest1
    {
        public static string PdfFileLocation = @"C:\Users\mirza\Source\Repos\FillPdf\Selma\Selma.Test\Prazna.pdf";

        [TestMethod]
        public void TestMethod1()
        {
            PdfReader reader = new PdfReader(PdfFileLocation);
            PdfStamper stamper = new PdfStamper(reader, new FileStream(@"C:\Users\mirza\Source\Repos\FillPdf\Selma\Selma.Test\PdfTest.pdf", FileMode.Create));

            // Ime i prezime
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 570, 120, 12)), "CandidateFullName", "Mirza Merdović").GetTextField(), 1);

            // Ime jednog roditelja
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 554, 120, 12)), "CandidateParentName", "Dedo").GetTextField(), 1);

            //Datum i mjesto rodjenja
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 538, 120, 12)), "CandidateBirthDayAndDate", "01.10.1984 Priboj").GetTextField(), 1);

            // JMBG
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 524, 120, 12)), "CandidateJmbg", "01101984793413").GetTextField(), 1);

            // Drzavljanstvo
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 508, 120, 12)), "CandidateCitizenship", "BIH").GetTextField(), 1);

            // Zanimanje
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 492, 120, 12)), "CandidateOccupancy", "Softver developer").GetTextField(), 1);

            // Adresa stanovanja
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 476, 120, 12)), "CandidateAddress", "Aleja Lipa 71000 Sarajevo").GetTextField(), 1);

            // Za koju kategoriju polaze ispit
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 460, 120, 12)), "CandidateDrivingLicenceCategory", "B").GetTextField(), 1);

            // Auto-skola u kojoj je obavljeno osposobljavanje
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 444, 120, 12)), "CandidateDrivingSchoolName", "Selma").GetTextField(), 1);

            // Broj izlazaka na ispit
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 428, 120, 12)), "CandidateExamCount", "1").GetTextField(), 1);

            // Da li posjeduje vozacku dozvolu (navesti kategoriju, broj i datum izdavanja)
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 414, 120, 12)), "CandidateHasDrivingLicence", "Nema").GetTextField(), 1);

            // Izrecena mjera zabrane izdavanja, oduzimanja vozacke dozvole (ko i kada)
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(390, 400, 120, 12)), "CandidateCanHaveDrivingLicence", "Nema").GetTextField(), 1);

            // Dan i mjesec
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(110, 69, 40, 12)), "CandidateDayAndMonth", "16.12").GetTextField(), 1);

            // Godina
            stamper.AddAnnotation(Create(stamper.Writer, new Rectangle(new RectangleJ(185, 69, 40, 12)), "CandidateYear", "17").GetTextField(), 1);

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

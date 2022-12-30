using ReportBuilder.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ReportBuilder.DAL;

namespace ReportBuilder.BLL
{
    public class LabPdfWriter
    {
        public void CreateFile(string filepath, string fontpath, LabsTemplate template, PersonalData personalData)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            Document document = new Document(PageSize.A4);

            PdfWriter.GetInstance(document, new FileStream(filepath, FileMode.Create));

            BaseFont bf = BaseFont.CreateFont(fontpath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font timesRegular = new Font(bf, 14);
            Font timesBold = new Font(bf, 14, 1);

            Paragraph titleTop = new Paragraph(CommonData.GenerateTitleTopText(template), timesRegular);
            titleTop.Alignment = Element.ALIGN_CENTER;

            Paragraph titleRight = new Paragraph(CommonData.GenerateTitleRightText(personalData), timesRegular);
            titleRight.Alignment = Element.ALIGN_RIGHT;

            Paragraph titleBottom = new Paragraph($"Гомель {DateTime.UtcNow.Year}", timesRegular);
            titleBottom.Alignment = Element.ALIGN_CENTER;

            Paragraph purpose = new Paragraph();
            Phrase purposePhrase = new Phrase();
            purposePhrase.Add(new Chunk($"               Цель работы:", timesBold));
            purposePhrase.Add(new Chunk(template.Purpose, timesRegular));
            purpose.Add(purposePhrase);

            Paragraph conclusion = new Paragraph();
            Phrase conclusionPhrase = new Phrase();
            conclusionPhrase.Add(new Chunk($"               Вывод: ", timesBold));
            conclusionPhrase.Add(new Chunk(template.Conclusion, timesRegular));
            conclusion.Add(conclusionPhrase);
            conclusion.Alignment = Element.ALIGN_JUSTIFIED;

            Paragraph workProcessTitle = new Paragraph("\nХод работы", timesBold);
            workProcessTitle.Alignment = Element.ALIGN_CENTER;

            document.Open();

            document.Add(titleTop);
            document.Add(titleRight);
            document.Add(titleBottom);
            document.Add(purpose);
            document.Add(workProcessTitle);
            document.Add(conclusion);

            document.Close();
        }
    }
}

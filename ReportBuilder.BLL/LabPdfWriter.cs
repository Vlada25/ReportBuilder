using AutoMapper;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ReportBuilder.BLL.Domain;
using ReportBuilder.DAL.Common;
using ReportBuilder.DAL.Enums;
using ReportBuilder.DAL.Models;
using System.Text;

namespace ReportBuilder.BLL
{
    public class LabPdfWriter
    {
        public void CreateFile(PdfFileInfo fileInfo, IMapper mapper)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            Document document = new Document(PageSize.A4);

            PdfWriter.GetInstance(document, new FileStream(fileInfo.FilePath, FileMode.Create));

            BaseFont bf = BaseFont.CreateFont(fileInfo.FontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font timesRegular = new Font(bf, 14);
            Font timesBold = new Font(bf, 14, 1);

            Paragraph titleTop = new Paragraph(CommonData.GenerateTitleTopText(mapper.Map<LabsTemplate>(fileInfo.LabsTemplate)), timesRegular);
            titleTop.Alignment = Element.ALIGN_CENTER;

            Paragraph titleRight = new Paragraph(CommonData.GenerateTitleRightText(fileInfo.PersonalData), timesRegular);
            titleRight.Alignment = Element.ALIGN_RIGHT;

            Paragraph titleBottom = new Paragraph($"Гомель {DateTime.UtcNow.Year}", timesRegular);
            titleBottom.Alignment = Element.ALIGN_CENTER;


            Paragraph purpose = new Paragraph();
            Phrase purposePhrase = new Phrase
            {
                new Chunk($"{Constants.Tab}Цель работы:", timesBold),
                new Chunk(fileInfo.LabsTemplate.Purpose, timesRegular)
            };
            purpose.Add(purposePhrase);


            Paragraph conclusion = new Paragraph("\n");
            Phrase conclusionPhrase = new Phrase
            {
                new Chunk($"{Constants.Tab}Вывод: ", timesBold),
                new Chunk(fileInfo.LabsTemplate.Conclusion, timesRegular),
            };
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

            foreach (var item in fileInfo.ReportElements)
            {
                if (item.ElementType.Equals(ReportElementType.Paragraph))
                {
                    Paragraph paragraph = new Paragraph(item.Text, timesRegular);
                    document.Add(paragraph);
                }
                else if (item.ElementType.Equals(ReportElementType.Table))
                {
                    var tableItem = fileInfo.TableElements.FirstOrDefault(x => x.Id.Equals(item.Id));

                    PdfPTable table = new PdfPTable(tableItem.ColumnsCount);

                    if (tableItem.HorizontalTitles is null)
                    {
                        var titles = tableItem.VerticalTitles.Split(';');
                        for (int i = 0; i < tableItem.RowsCount; i++)
                        {
                            table.AddCell(new Phrase(titles[i], timesRegular));
                            for (int j = 1; j < tableItem.ColumnsCount; j++)
                            {
                                table.AddCell(new Phrase(" ", timesRegular));
                            }
                        }
                    }
                    else
                    {

                    }

                    Paragraph paragraph = new Paragraph("\n");
                    Phrase phrase = new Phrase
                    {
                        new Chunk($"{Constants.Tab}Таблица {tableItem.Number} - {tableItem.Text}", timesRegular),
                        table
                    };
                    paragraph.Add(phrase);

                    document.Add(paragraph);
                }
                else
                {
                    var pictureItem = fileInfo.PictureElements.FirstOrDefault(x => x.Id.Equals(item.Id));

                    Paragraph paragraph = new Paragraph($"\nРисунок {pictureItem.Number} - {pictureItem.Text}", timesRegular);
                    paragraph.Alignment = Element.ALIGN_CENTER;

                    document.Add(new Paragraph("\n"));

                    if (pictureItem.FileName is not null)
                    {
                        var picture = Image.GetInstance(new FileStream($"{fileInfo.PicturesPath}\\{pictureItem.FileName}", FileMode.Open));

                        var koef = picture.Height / picture.Width;
                        picture.ScaleAbsolute(400f, 400f * koef);

                        picture.Alignment = Element.ALIGN_CENTER;

                        document.Add(picture);
                    }
                    
                    document.Add(paragraph);
                }
            }

            document.Add(conclusion);

            document.Close();
        }
    }
}

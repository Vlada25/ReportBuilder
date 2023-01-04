using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReportBuilder.DAL.Enums;
using ReportBuilder.DAL.Models.ReportElements;

namespace ReportBuilder.DAL.Configuration
{
    public class ParagraphElementConfig : IEntityTypeConfiguration<ParagraphElement>
    {
        public void Configure(EntityTypeBuilder<ParagraphElement> builder)
        {
            builder.HasData(new List<ParagraphElement>
            {
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 0,
                    ElementType = ReportElementType.Paragraph,
                    Text = "               1. Исследование шунта.\n               1.1. Собираем схему на рис.1 и снимаем значения Uш и Iн"
                }
            });
        }
    }
}

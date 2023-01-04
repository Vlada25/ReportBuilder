using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReportBuilder.DAL.Enums;
using ReportBuilder.DAL.Models.ReportElements;

namespace ReportBuilder.DAL.Configuration
{
    public class PictureElementConfig : IEntityTypeConfiguration<PictureElement>
    {
        public void Configure(EntityTypeBuilder<PictureElement> builder)
        {
            builder.HasData(new List<PictureElement>
            {
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 1,
                    ElementType = ReportElementType.Picture,
                    Text = "Схема исследования шунта",
                    PictureNumber = 1
                }
            });
        }
    }
}

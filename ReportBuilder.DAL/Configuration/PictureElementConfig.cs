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
                // -------------------------------------------
                // Lab 1
                // -------------------------------------------
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 1,
                    ElementType = ReportElementType.Picture,
                    Text = "Схема исследования шунта",
                    PictureNumber = 1
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 4,
                    ElementType = ReportElementType.Picture,
                    Text = "График зависимости Uш=f(Iн)",
                    PictureNumber = 2
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 6,
                    ElementType = ReportElementType.Picture,
                    Text = "Схема исследования трансформатора тока",
                    PictureNumber = 3
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 9,
                    ElementType = ReportElementType.Picture,
                    Text = "График зависимости I2=f(I1)",
                    PictureNumber = 4
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 11,
                    ElementType = ReportElementType.Picture,
                    Text = "Схема исследования трансформатора напряжения",
                    PictureNumber = 5
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 14,
                    ElementType = ReportElementType.Picture,
                    Text = "График зависимости U2=f(U1)",
                    PictureNumber = 6
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 16,
                    ElementType = ReportElementType.Picture,
                    Text = "Схема исследования датчика тока на эффекте Холла",
                    PictureNumber = 7
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 19,
                    ElementType = ReportElementType.Picture,
                    Text = "График зависимости I2=f(I1)",
                    PictureNumber = 8
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 21,
                    ElementType = ReportElementType.Picture,
                    Text = "Схема исследования датчика напряжения на эффекте Холла",
                    PictureNumber = 9
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 24,
                    ElementType = ReportElementType.Picture,
                    Text = "График зависимости I=f(U)",
                    PictureNumber = 10
                },

                // -------------------------------------------
                // Lab 3
                // -------------------------------------------
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"),
                    Number = 1,
                    ElementType = ReportElementType.Picture,
                    Text = "Схема включения источника регулируемого напряжения",
                    PictureNumber = 1
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"),
                    Number = 3,
                    ElementType = ReportElementType.Picture,
                    Text = "Схема исследования тахогенератора и энкодера",
                    PictureNumber = 2
                },
            });
        }
    }
}

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
                // Lab 2
                // -------------------------------------------
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"),
                    Number = 1,
                    ElementType = ReportElementType.Picture,
                    Text = "Схема исследования терморезистора",
                    PictureNumber = 1
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"),
                    Number = 9,
                    ElementType = ReportElementType.Picture,
                    Text = "ВАХ терморезистора",
                    PictureNumber = 2
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"),
                    Number = 10,
                    ElementType = ReportElementType.Picture,
                    Text = "График T(U)",
                    PictureNumber = 3
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
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"),
                    Number = 7,
                    ElementType = ReportElementType.Picture,
                    Text = "Экспериментальная характеристика Uг = f(n).",
                    PictureNumber = 3
                },

                // -------------------------------------------
                // Lab 4
                // -------------------------------------------
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 1,
                    ElementType = ReportElementType.Picture,
                    Text = "Схема включения мультиметра для исследования резистивного датчика линейного перемещения",
                    PictureNumber = 1
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 5,
                    ElementType = ReportElementType.Picture,
                    Text = "Статическая характеристика R = f(X).",
                    PictureNumber = 2
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 9,
                    ElementType = ReportElementType.Picture,
                    Text = "Статическая характеристика N = f(X).",
                    PictureNumber = 3
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 11,
                    ElementType = ReportElementType.Picture,
                    Text = "Схема подключения мультиметра для исследования ёмкостного датчика линейного перемещения",
                    PictureNumber = 4
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 15,
                    ElementType = ReportElementType.Picture,
                    Text = "Статическая характеристика Cx = f(X).",
                    PictureNumber = 5
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 17,
                    ElementType = ReportElementType.Picture,
                    Text = "Схема подключения мультиметра для исследования индуктивного датчика линейного перемещения",
                    PictureNumber = 6
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 21,
                    ElementType = ReportElementType.Picture,
                    Text = "Статическая характеристика Lx =f(X)",
                    PictureNumber = 7
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 23,
                    ElementType = ReportElementType.Picture,
                    Text = "Схема исследования ультразвукового датчика линейного перемещения",
                    PictureNumber = 8
                },

                // -------------------------------------------
                // Lab 5
                // -------------------------------------------
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("202b2d34-b93e-45db-935b-3a1d050f36bb"),
                    Number = 1,
                    ElementType = ReportElementType.Picture,
                    Text = "Блок бесконтактных датчиков-выключателей",
                    PictureNumber = 1
                },

                // -------------------------------------------
                // Lab 6
                // -------------------------------------------
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"),
                    Number = 1,
                    ElementType = ReportElementType.Picture,
                    Text = "Схема подключения мультиметра для исследования потенциометра.",
                    PictureNumber = 1
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"),
                    Number = 5,
                    ElementType = ReportElementType.Picture,
                    Text = "Характеристика R=f(α)",
                    PictureNumber = 2
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"),
                    Number = 7,
                    ElementType = ReportElementType.Picture,
                    Text = "Схема для исследования цифрового датчика угла",
                    PictureNumber = 3
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"),
                    Number = 11,
                    ElementType = ReportElementType.Picture,
                    Text = "Характеристика N=f(α).",
                    PictureNumber = 4
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"),
                    Number = 13,
                    ElementType = ReportElementType.Picture,
                    Text = "Схема подключения мультиметра для исследования делителя напряжения.",
                    PictureNumber = 5
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"),
                    Number = 17,
                    ElementType = ReportElementType.Picture,
                    Text = "Характеристика U=f(α).",
                    PictureNumber = 6
                },
                // -------------------------------------------
                // Lab 7
                // -------------------------------------------
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("8133fde9-ab3a-4e8d-b819-4d543cdfa485"),
                    Number = 1,
                    ElementType = ReportElementType.Picture,
                    Text = "Схема подключения мультиметра для исследования датчика дваления.",
                    PictureNumber = 1
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("8133fde9-ab3a-4e8d-b819-4d543cdfa485"),
                    Number = 2,
                    ElementType = ReportElementType.Picture,
                    Text = "Установка для исследования датчика давления.",
                    PictureNumber = 2
                },
                new PictureElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("8133fde9-ab3a-4e8d-b819-4d543cdfa485"),
                    Number = 6,
                    ElementType = ReportElementType.Picture,
                    Text = "Характеристика U=f(P).",
                    PictureNumber = 3
                },
            });
        }
    }
}

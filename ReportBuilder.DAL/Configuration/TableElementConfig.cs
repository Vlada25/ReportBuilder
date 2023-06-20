using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReportBuilder.DAL.Enums;
using ReportBuilder.DAL.Models.ReportElements;

namespace ReportBuilder.DAL.Configuration
{
    public class TableElementConfig : IEntityTypeConfiguration<TableElement>
    {
        public void Configure(EntityTypeBuilder<TableElement> builder)
        {
            builder.HasData(new List<TableElement>
            {
                // -------------------------------------------
                // Lab 1
                // -------------------------------------------
                new TableElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 2,
                    ElementType = ReportElementType.Table,
                    Text = "Данные эксперимента",
                    TableNumber = 1,
                    RowsCount = 3,
                    ColumnsCount = 12,
                    VerticalTitles = "Uш,мВ;Iн,А;Iш,А",
                    HorizontalTitles = null
                },
                new TableElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 7,
                    ElementType = ReportElementType.Table,
                    Text = "Данные эксперимента",
                    TableNumber = 2,
                    RowsCount = 2,
                    ColumnsCount = 9,
                    VerticalTitles = "I1,мА;I2,мА",
                    HorizontalTitles = null
                },
                new TableElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 12,
                    ElementType = ReportElementType.Table,
                    Text = "Данные эксперимента",
                    TableNumber = 3,
                    RowsCount = 2,
                    ColumnsCount = 12,
                    VerticalTitles = "U1,В;U2,В",
                    HorizontalTitles = null
                },
                new TableElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 17,
                    ElementType = ReportElementType.Table,
                    Text = "Данные эксперимента",
                    TableNumber = 4,
                    RowsCount = 2,
                    ColumnsCount = 10,
                    VerticalTitles = "I1,А;I2,мА",
                    HorizontalTitles = null
                },
                new TableElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 22,
                    ElementType = ReportElementType.Table,
                    Text = "Данные эксперимента",
                    TableNumber = 5,
                    RowsCount = 2,
                    ColumnsCount = 12,
                    VerticalTitles = "U,В;I,мА",
                    HorizontalTitles = null
                },

                // -------------------------------------------
                // Lab 2
                // -------------------------------------------
                new TableElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"),
                    Number = 3,
                    ElementType = ReportElementType.Table,
                    Text = "Значения сопротивления терморезистора при различных значениях температуры.",
                    TableNumber = 1,
                    RowsCount = 2,
                    ColumnsCount = 9,
                    VerticalTitles = "T,°C;R, Ом",
                    HorizontalTitles = null
                },
                new TableElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"),
                    Number = 5,
                    ElementType = ReportElementType.Table,
                    Text = "Результаты эксперимента",
                    TableNumber = 2,
                    RowsCount = 3,
                    ColumnsCount = 9,
                    VerticalTitles = "T,°C;Uш, мВ;Iш, мА",
                    HorizontalTitles = null
                },
                new TableElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"),
                    Number = 7,
                    ElementType = ReportElementType.Table,
                    Text = "Значения напряженияя на терморезисторе",
                    TableNumber = 3,
                    RowsCount = 4,
                    ColumnsCount = 9,
                    VerticalTitles = "T,°C;R, Ом;Iш, мА;U, мВ",
                    HorizontalTitles = null
                },

                // -------------------------------------------
                // Lab 3
                // -------------------------------------------
                new TableElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"),
                    Number = 5,
                    ElementType = ReportElementType.Table,
                    Text = "Данные эксперимента",
                    TableNumber = 1,
                    RowsCount = 13,
                    ColumnsCount = 5,
                    VerticalTitles = null,
                    HorizontalTitles = "№ п/п;U1;Uг,В;n,об/мин;nг,об/мин"
                },

                // -------------------------------------------
                // Lab 4
                // -------------------------------------------
                new TableElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 3,
                    ElementType = ReportElementType.Table,
                    Text = "Данные эксперимента",
                    TableNumber = 1,
                    RowsCount = 11,
                    ColumnsCount = 3,
                    VerticalTitles = null,
                    HorizontalTitles = "№ п/п;X, см;R, кОм"
                },
                new TableElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 7,
                    ElementType = ReportElementType.Table,
                    Text = "Данные эксперимента",
                    TableNumber = 2,
                    RowsCount = 9,
                    ColumnsCount = 4,
                    VerticalTitles = null,
                    HorizontalTitles = "Диодная оптопара Х, см;Диодная оптопара N, шаг;Транзисторная оптопара Х, см;Транзисторная оптопара N, шаг"
                },
                new TableElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 13,
                    ElementType = ReportElementType.Table,
                    Text = "Данные эксперимента",
                    TableNumber = 3,
                    RowsCount = 14,
                    ColumnsCount = 3,
                    VerticalTitles = null,
                    HorizontalTitles = "№ п/п;X, см;Cx, nF"
                },
                new TableElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 19,
                    ElementType = ReportElementType.Table,
                    Text = "Данные эксперимента",
                    TableNumber = 4,
                    RowsCount = 10,
                    ColumnsCount = 3,
                    VerticalTitles = null,
                    HorizontalTitles = "№ п/п;X, см;Lx, mH"
                },
                new TableElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 25,
                    ElementType = ReportElementType.Table,
                    Text = "Данные эксперимента",
                    TableNumber = 5,
                    RowsCount = 7,
                    ColumnsCount = 2,
                    VerticalTitles = null,
                    HorizontalTitles = "Ультразвуковой датчик Х, см;Рулетка (линейка) Х, см"
                },

                // -------------------------------------------
                // Lab 6
                // -------------------------------------------
                new TableElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"),
                    Number = 3,
                    ElementType = ReportElementType.Table,
                    Text = "Экспериментальные данные",
                    TableNumber = 1,
                    RowsCount = 11,
                    ColumnsCount = 2,
                    VerticalTitles = null,
                    HorizontalTitles = "α, градусы;R, кОм"
                },
                new TableElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"),
                    Number = 9,
                    ElementType = ReportElementType.Table,
                    Text = "Экспериментальные данные",
                    TableNumber = 2,
                    RowsCount = 11,
                    ColumnsCount = 3,
                    VerticalTitles = null,
                    HorizontalTitles = "α, градусы;Комбинация светодиодов;Комбинация в dec"
                },
                new TableElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"),
                    Number = 15,
                    ElementType = ReportElementType.Table,
                    Text = "Экспериментальные данные",
                    TableNumber = 3,
                    RowsCount = 8,
                    ColumnsCount = 2,
                    VerticalTitles = null,
                    HorizontalTitles = "α, градусы;U, В"
                },

                // -------------------------------------------
                // Lab 7
                // -------------------------------------------
                new TableElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("8133fde9-ab3a-4e8d-b819-4d543cdfa485"),
                    Number = 4,
                    ElementType = ReportElementType.Table,
                    Text = "Экспериментальные данные",
                    TableNumber = 1,
                    RowsCount = 13,
                    ColumnsCount = 2,
                    VerticalTitles = null,
                    HorizontalTitles = "Р, МПа;U, мВ"
                },
            });
        }
    }
}

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
            });
        }
    }
}

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
                new TableElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 2,
                    ElementType = ReportElementType.Table,
                    Text = "Данные эксперимента",
                    TableNumber = 1,
                    RowsCount = 3,
                    ColumnsCount = 13,
                    VerticalTitles = "Uш, мВ;Iн, А;Iш, А",
                    HorizontalTitles = null
                }
            });
        }
    }
}

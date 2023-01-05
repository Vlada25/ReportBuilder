using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReportBuilder.DAL.Migrations
{
    public partial class Test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("b3a36f8d-4a7b-4b8b-a197-20f9c58a5124"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("5abc4dfa-29dd-4c9c-8588-1f56d44254c5"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("2fd6351c-8dc7-4a9f-9208-7999ae8ba140"));

            migrationBuilder.UpdateData(
                table: "LabsTemplates",
                keyColumn: "Id",
                keyValue: new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"),
                column: "Purpose",
                value: "\n              1. Исследование потенциометра\n              2. Изучить принцип работы датчиков углового положения\n              3. Исследовать характеристики датчиков углового положения");

            migrationBuilder.UpdateData(
                table: "LabsTemplates",
                keyColumn: "Id",
                keyValue: new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                column: "Purpose",
                value: "\n              1. Изучить принцип работы датчиков тока и напряжения\n              2. Исследовать статические характеристики датчиков тока и напряжения");

            migrationBuilder.UpdateData(
                table: "LabsTemplates",
                keyColumn: "Id",
                keyValue: new Guid("8133fde9-ab3a-4e8d-b819-4d543cdfa485"),
                column: "Purpose",
                value: "\n              1. Изучить устройство и принцип работы датчика давления.\n              2. Исследовать статическую характеристику датчика давления\n");

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "Discriminator", "ElementType", "LabTemplateId", "Number", "Text" },
                values: new object[] { new Guid("08afffab-5897-48ee-bdc5-f7bb784f87bc"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 0, "              1. Исследование шунта.\n              1.1. Собираем схему на рис.1 и снимаем значения Uш и Iн" });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "Discriminator", "ElementType", "LabTemplateId", "Number", "PictureNumber", "Text" },
                values: new object[] { new Guid("9a89aeb4-3a80-4e75-91e5-c67d0dd86f7a"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 1, 1, "Схема исследования шунта" });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "ColumnsCount", "Discriminator", "ElementType", "HorizontalTitles", "LabTemplateId", "Number", "RowsCount", "TableNumber", "Text", "VerticalTitles" },
                values: new object[] { new Guid("0ec4a256-1c22-460f-9731-f21d353f15ef"), 13, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 2, 3, 1, "Данные эксперимента", "Uш, мВ;Iн, А;Iш, А" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("08afffab-5897-48ee-bdc5-f7bb784f87bc"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("9a89aeb4-3a80-4e75-91e5-c67d0dd86f7a"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("0ec4a256-1c22-460f-9731-f21d353f15ef"));

            migrationBuilder.UpdateData(
                table: "LabsTemplates",
                keyColumn: "Id",
                keyValue: new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"),
                column: "Purpose",
                value: "\n               1. Исследование потенциометра\n               2. Изучить принцип работы датчиков углового положения\n               3. Исследовать характеристики датчиков углового положения");

            migrationBuilder.UpdateData(
                table: "LabsTemplates",
                keyColumn: "Id",
                keyValue: new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                column: "Purpose",
                value: "\n               1. Изучить принцип работы датчиков тока и напряжения\n               2. Исследовать статические характеристики датчиков тока и напряжения");

            migrationBuilder.UpdateData(
                table: "LabsTemplates",
                keyColumn: "Id",
                keyValue: new Guid("8133fde9-ab3a-4e8d-b819-4d543cdfa485"),
                column: "Purpose",
                value: "\n               1. Изучить устройство и принцип работы датчика давления.\n               2. Исследовать статическую характеристику датчика давления\n");

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "Discriminator", "ElementType", "LabTemplateId", "Number", "Text" },
                values: new object[] { new Guid("b3a36f8d-4a7b-4b8b-a197-20f9c58a5124"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 0, "               1. Исследование шунта.\n               1.1. Собираем схему на рис.1 и снимаем значения Uш и Iн" });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "Discriminator", "ElementType", "LabTemplateId", "Number", "PictureNumber", "Text" },
                values: new object[] { new Guid("5abc4dfa-29dd-4c9c-8588-1f56d44254c5"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 1, 1, "Схема исследования шунта" });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "ColumnsCount", "Discriminator", "ElementType", "HorizontalTitles", "LabTemplateId", "Number", "RowsCount", "TableNumber", "Text", "VerticalTitles" },
                values: new object[] { new Guid("2fd6351c-8dc7-4a9f-9208-7999ae8ba140"), 13, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 2, 3, 1, "Данные эксперимента", "Uш, мВ;Iн, А;Iш, А" });
        }
    }
}

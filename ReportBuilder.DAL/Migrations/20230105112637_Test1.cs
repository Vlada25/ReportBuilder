using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReportBuilder.DAL.Migrations
{
    public partial class Test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LabsTemplates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Theme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Conclusion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabsTemplates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportElements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LabTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    ElementType = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureNumber = table.Column<int>(type: "int", nullable: true),
                    TableNumber = table.Column<int>(type: "int", nullable: true),
                    RowsCount = table.Column<int>(type: "int", nullable: true),
                    ColumnsCount = table.Column<int>(type: "int", nullable: true),
                    VerticalTitles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HorizontalTitles = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportElements", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "LabsTemplates",
                columns: new[] { "Id", "Conclusion", "Number", "Purpose", "Theme" },
                values: new object[,]
                {
                    { new Guid("202b2d34-b93e-45db-935b-3a1d050f36bb"), "в ходе работы были изучены на практике принцип работы бесконтактных датчиков-выключателей.", 5, " изучить устройство и принцип работы бесконтактных датчиков-выключателей.", "Изучение принципа работы бесконтактных датчиков выключателей" },
                    { new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"), "в ходе лабораторной работы изучили принцип работы датчиков углового положения. Исследовали характеристики датчиков углового положения.", 6, "\n               1. Исследование потенциометра\n               2. Изучить принцип работы датчиков углового положения\n               3. Исследовать характеристики датчиков углового положения", "Статические характеристики датчиков углового положения" },
                    { new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"), "в ходе работы был изучен принцип работы тахогенератора (тахогенератор работает в генераторном режиме, и, снимая с его обмоток ЭДС, можно вычислить частоту вращения) и энкодера (энкодер состоит из оптического датчика и перфорированного диска; подсчитывая количество импульсов, можно определить угол поворота вращающегося вала). Также были исследованы их характеристики.", 3, " изучить принцип работы тахогенератора и энкодера. Исследовать характеристики тахогенератора и энкодера.", "Статические характеристики тахогенератора и энкодера" },
                    { new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), "в ходе лабораторной работы изучил принцип работы датчиков тока и напряжения, а также на практике исследовал статические характеристики этих датчиков. По результатам  экспериментальных измерений было доказано, что зависимости измеряемых величин от входных значений имеют линейный характер, что облегчает съем измеряемых величин.", 1, "\n               1. Изучить принцип работы датчиков тока и напряжения\n               2. Исследовать статические характеристики датчиков тока и напряжения", "Статические характеристики датчиков тока и напряжения" },
                    { new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), "в ходе работы были изучены принцип работы датчиков линейного перемещения, а также исследованы характеристики датчиков линейного перемещения.", 4, " изучить принцип работы датчиков линейного перемещения. Исследовать характеристики датчиков линейного перемещения.", "Статические характеристики датчиков линейного перемещения" },
                    { new Guid("8133fde9-ab3a-4e8d-b819-4d543cdfa485"), "в ходе лабораторной работы изучили устройство и принцип работы датчика давления. Исследовали статическую характеристику датчика давления.", 7, "\n               1. Изучить устройство и принцип работы датчика давления.\n               2. Исследовать статическую характеристику датчика давления\n", "Статическая характеристика датчика давления" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LabsTemplates");

            migrationBuilder.DropTable(
                name: "ReportElements");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReportBuilder.DAL.Migrations
{
    public partial class AddFullDataForLab1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b3d6a88-6b76-4bce-abd7-0074fa861d0f");

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("3c540102-6e4b-4ec4-b51b-9e28a0f384cc"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("2e5e5486-cbd7-4b02-994e-fb56923a461d"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("cf6e4a35-eea9-4ac7-bdb2-559b2c02a28e"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c563cf52-7b33-4cfb-832c-25310f4625ae", "cd2703a5-f732-4b2a-9b8f-87f64ed3c391", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "Discriminator", "ElementType", "LabTemplateId", "Number", "Text" },
                values: new object[,]
                {
                    { new Guid("421ae3c6-d37b-41a8-a4ef-6510151c2155"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 10, "          3. Исследование измерительного трансформатора напряжения.\n          3.1. Собираем схему на рис.5 и снимаем значения U1 и U2." },
                    { new Guid("564af35a-cc62-4ca4-a20f-44e3042ac029"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 3, "          где Iш=Uш/Rш, Rш=100 мОм\n          1.2.Строим статическую характеристику Uш=f(Iн)." },
                    { new Guid("5ddeec08-8937-4847-8d71-fdb4b6f6011b"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 15, "          4. Исследование датчика тока на эффекте Холла.\n          4.1. Собираем схему на рис.7 и снимаем значения I1 и I2." },
                    { new Guid("92300039-a733-472d-a9d2-3439f191690d"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 0, "          1. Исследование шунта.\n          1.1. Собираем схему на рис.1 и снимаем значения Uш и Iн." },
                    { new Guid("9cba66eb-a2e9-44f7-a5d5-2e7f939a4fe0"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 8, "          2.2.Строим статическую характеристику I2=f(I1)." },
                    { new Guid("abb91f43-3f4d-4ec8-acb9-5f356f61295b"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 5, "          2.Исследование трансформатора тока.\n          2.1.Собираем схему на рис.3 и снимаем значения I1 и I2." },
                    { new Guid("b7003bd8-b857-4486-ad6d-abf82e93186d"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 13, "          3.2.Строим статическую характеристику U2=f(U1)." },
                    { new Guid("b8e2ab11-aad2-44ac-a91d-57925056fae9"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 18, "          4.2.Строим статическую характеристику I2=f(I1)." },
                    { new Guid("c221eae5-7623-4850-a008-5bda6ddb7fdf"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 20, "          5. Исследование датчика напряжения на эффекте Холла.\n          5.1. Собираем схему на рис.9 и снимаем значения U и I." },
                    { new Guid("ebcfafe0-908c-4915-a23c-85ae453ceb6e"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 23, "          5.2.Строим статическую характеристику I=f(U)." }
                });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "Discriminator", "ElementType", "LabTemplateId", "Number", "PictureNumber", "Text" },
                values: new object[,]
                {
                    { new Guid("07122f52-6532-4644-bfda-a18cd5ff99ec"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 1, 1, "Схема исследования шунта" },
                    { new Guid("27b2438b-2595-4ac4-9ff2-4eecb85945ee"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 9, 4, "График зависимости I2=f(I1)" },
                    { new Guid("595610a9-8ee5-4cd7-9d79-30c5a9a12704"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 11, 5, "Схема исследования трансформатора напряжения" },
                    { new Guid("5de7f780-c604-44f4-bc4e-b617a4ef2c68"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 21, 9, "Схема исследования датчика напряжения на эффекте Холла" },
                    { new Guid("71870581-67f1-4934-82d9-05020a52457a"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 16, 7, "Схема исследования датчика тока на эффекте Холла" },
                    { new Guid("94ba7088-3c30-4bde-9424-a562a2e6725b"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 24, 10, "График зависимости I=f(U)" },
                    { new Guid("b6549bcf-7a70-4363-a6f1-76098c9e57a9"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 14, 6, "График зависимости U2=f(U1)" },
                    { new Guid("daebda1f-4c4a-4ee3-87a5-41c53c788309"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 19, 8, "График зависимости I2=f(I1)" },
                    { new Guid("e3e6e67d-57bc-4909-8518-5d90ed50cf76"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 6, 3, "Схема исследования трансформатора тока" },
                    { new Guid("ef33a464-3d16-4e80-89ea-192cd4ce4c9d"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 4, 2, "График зависимости Uш=f(Iн)" }
                });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "ColumnsCount", "Discriminator", "ElementType", "HorizontalTitles", "LabTemplateId", "Number", "RowsCount", "TableNumber", "Text", "VerticalTitles" },
                values: new object[,]
                {
                    { new Guid("21f36567-f1e9-4e75-9aab-a45b11c29961"), 12, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 2, 3, 1, "Данные эксперимента", "Uш,мВ;Iн,А;Iш,А" },
                    { new Guid("276834fd-b66d-414e-98e7-64350d15532f"), 12, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 12, 2, 3, "Данные эксперимента", "U1,В;U2,В" },
                    { new Guid("da69b8be-77a2-4597-958c-6a60c8504e60"), 9, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 7, 2, 2, "Данные эксперимента", "I1,мА;I2,мА" },
                    { new Guid("daf24e46-d6a2-48d4-89ee-2b6928a0930e"), 10, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 17, 2, 4, "Данные эксперимента", "I1,А;I2,мА" },
                    { new Guid("f472afa5-18ec-47fe-82c2-cc0322d10980"), 12, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 22, 2, 5, "Данные эксперимента", "U,В;I,мА" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c563cf52-7b33-4cfb-832c-25310f4625ae");

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("421ae3c6-d37b-41a8-a4ef-6510151c2155"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("564af35a-cc62-4ca4-a20f-44e3042ac029"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("5ddeec08-8937-4847-8d71-fdb4b6f6011b"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("92300039-a733-472d-a9d2-3439f191690d"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("9cba66eb-a2e9-44f7-a5d5-2e7f939a4fe0"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("abb91f43-3f4d-4ec8-acb9-5f356f61295b"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("b7003bd8-b857-4486-ad6d-abf82e93186d"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("b8e2ab11-aad2-44ac-a91d-57925056fae9"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("c221eae5-7623-4850-a008-5bda6ddb7fdf"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("ebcfafe0-908c-4915-a23c-85ae453ceb6e"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("07122f52-6532-4644-bfda-a18cd5ff99ec"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("27b2438b-2595-4ac4-9ff2-4eecb85945ee"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("595610a9-8ee5-4cd7-9d79-30c5a9a12704"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("5de7f780-c604-44f4-bc4e-b617a4ef2c68"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("71870581-67f1-4934-82d9-05020a52457a"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("94ba7088-3c30-4bde-9424-a562a2e6725b"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("b6549bcf-7a70-4363-a6f1-76098c9e57a9"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("daebda1f-4c4a-4ee3-87a5-41c53c788309"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("e3e6e67d-57bc-4909-8518-5d90ed50cf76"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("ef33a464-3d16-4e80-89ea-192cd4ce4c9d"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("21f36567-f1e9-4e75-9aab-a45b11c29961"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("276834fd-b66d-414e-98e7-64350d15532f"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("da69b8be-77a2-4597-958c-6a60c8504e60"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("daf24e46-d6a2-48d4-89ee-2b6928a0930e"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("f472afa5-18ec-47fe-82c2-cc0322d10980"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2b3d6a88-6b76-4bce-abd7-0074fa861d0f", "f6106a75-9643-4a62-bb7d-7dc1c1fb1962", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "Discriminator", "ElementType", "LabTemplateId", "Number", "Text" },
                values: new object[] { new Guid("3c540102-6e4b-4ec4-b51b-9e28a0f384cc"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 0, "          1. Исследование шунта.\n          1.1. Собираем схему на рис.1 и снимаем значения Uш и Iн" });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "Discriminator", "ElementType", "LabTemplateId", "Number", "PictureNumber", "Text" },
                values: new object[] { new Guid("2e5e5486-cbd7-4b02-994e-fb56923a461d"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 1, 1, "Схема исследования шунта" });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "ColumnsCount", "Discriminator", "ElementType", "HorizontalTitles", "LabTemplateId", "Number", "RowsCount", "TableNumber", "Text", "VerticalTitles" },
                values: new object[] { new Guid("cf6e4a35-eea9-4ac7-bdb2-559b2c02a28e"), 13, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 2, 3, 1, "Данные эксперимента", "Uш, мВ;Iн, А;Iш, А" });
        }
    }
}

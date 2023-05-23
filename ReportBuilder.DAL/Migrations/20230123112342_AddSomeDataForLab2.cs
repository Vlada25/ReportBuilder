using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReportBuilder.DAL.Migrations
{
    public partial class AddSomeDataForLab2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60bb650d-391a-47cc-a9cd-e6452976898f");

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("075c375f-7a09-48e4-ba50-4da0a665ecd9"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("213b95c9-9c4e-4cc4-a822-32e3c0757e60"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("2c31d8b0-a296-4cb2-8445-f4551ab37948"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("52587545-7936-4761-b602-28f62b41bc52"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("8811f813-d0fa-47ae-a2b0-95121901772f"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("a90009db-809c-4d67-a15c-80b5865aae48"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("b08dfa52-02ab-4356-919b-5a34c26f0954"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("c6e61783-53da-4a8b-a463-4160368d0270"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("e558e12b-9d38-46b2-97e9-8a70ac7a0713"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("efb4b48e-19b9-4810-a164-56872b734f14"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("2651fded-caaf-4096-b8cb-2642be45fa18"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("2d672f99-7ca5-420b-98a5-2dfc028f0e49"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("37226d0e-7681-4dd4-ad05-a112feedc754"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("414f9b63-ec69-41c9-98a0-5e2ee3dd1ef1"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("72d8f395-b14c-4e0d-8cc4-a0d40bdc9010"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("7a0eab93-25c1-49a3-b1c7-72daa2afb8bc"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("8b007e14-7cf7-4775-be4a-95496b04d756"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("a6ec28a2-14fa-4f4c-908e-d7515964db3b"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("d59c841f-a25f-4c57-9da1-db8101ea7fdf"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("dba05c5d-2117-4aa7-bc4b-b0d9edc1ca90"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("6e5960cc-329a-45e4-a16c-ec01b6af9f1f"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("7c7caf3f-f434-4ed8-ad01-e73e8ede9c20"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("8f4cd9e7-e2e8-44bb-9350-6d674ef24c79"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("a9e7c479-ec78-4b40-a995-4c1a9619a27a"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("fc0bba91-22c7-4005-bddc-c7acaefd3879"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aaf4a7d4-6ddf-40ff-8e36-5533f5c1e4a9", "e09643b1-84cc-465e-ba42-768b2db01d0f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "Discriminator", "ElementType", "LabTemplateId", "Number", "Text" },
                values: new object[,]
                {
                    { new Guid("0bb3286a-2129-417e-911c-e9cb6adec781"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 5, "\n          2.Исследование трансформатора тока.\n          2.1.Собираем схему на рис.3 и снимаем значения I1 и I2." },
                    { new Guid("176ca2cb-45c4-4305-8db3-24d61d8215dd"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 10, "\n          3. Исследование измерительного трансформатора напряжения.\n          3.1. Собираем схему на рис.5 и снимаем значения U1 и U2." },
                    { new Guid("215596ee-3852-47e6-9220-ed1697eb1824"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 3, "          где Iш=Uш/Rш, Rш=100 мОм\n\n          1.2.Строим статическую характеристику Uш=f(Iн)." },
                    { new Guid("23277a97-9df3-44a3-a6c9-18823052830f"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 13, "\n          3.2.Строим статическую характеристику U2=f(U1)." },
                    { new Guid("549b288b-80fe-44b9-937c-570054fe1b05"), "ParagraphElement", 0, new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"), 0, "          1. Подключаем стенд к однофазной сети переменного тока 220В, 50Гц.\n          2. Собираем схему источника регулируемого напряжения, как показано на рисунке 1." },
                    { new Guid("6efd4fc8-b664-43e8-82e3-3ecb216ccf0d"), "ParagraphElement", 0, new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"), 2, "          3. Подключаем мультиметр к гнездам тахогенератора BR1 и двигателя M1, как показано на рисунке 2. Выставляем пределы измерения 20В и 200В постоянного напряжения соответственно." },
                    { new Guid("7adf8355-6e51-44a9-a30f-616ab77a23e5"), "ParagraphElement", 0, new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"), 4, "          4. Регистрируем значение частоты вращения n на приборе EP1 и значение выходного напряжения Uг на тахогенераторе. Полученные данные заносим в таблицу 1." },
                    { new Guid("971c7491-7f53-440f-94c8-484132325a4e"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 0, "          1. Исследование шунта.\n          1.1. Собираем схему на рис.1 и снимаем значения Uш и Iн." },
                    { new Guid("d46fffaa-fd6a-40e0-9fb0-d2e4fd58b33e"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 8, "\n          2.2.Строим статическую характеристику I2=f(I1)." },
                    { new Guid("d8d6126e-dbea-4942-a1e4-c4df5bdeea6f"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 18, "\n          4.2.Строим статическую характеристику I2=f(I1)." },
                    { new Guid("e7a8aca1-865c-40b4-8a1b-8131126273c7"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 23, "\n          5.2.Строим статическую характеристику I=f(U)." },
                    { new Guid("ea88a7b8-a143-47cc-90af-b0bde1869596"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 15, "\n          4. Исследование датчика тока на эффекте Холла.\n          4.1. Собираем схему на рис.7 и снимаем значения I1 и I2." },
                    { new Guid("f59bafb9-0ab4-47da-b97b-fbf53a372a67"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 20, "\n          5. Исследование датчика напряжения на эффекте Холла.\n          5.1. Собираем схему на рис.9 и снимаем значения U и I." }
                });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "Discriminator", "ElementType", "LabTemplateId", "Number", "PictureNumber", "Text" },
                values: new object[,]
                {
                    { new Guid("0e4eed54-121b-4309-99e4-4e46bf9fea9b"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 11, 5, "Схема исследования трансформатора напряжения" },
                    { new Guid("0f4fcee3-a05e-4f59-96b9-f8dc185a28b5"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 19, 8, "График зависимости I2=f(I1)" },
                    { new Guid("28aaf1f5-41c7-432c-935f-f773315c15d8"), "PictureElement", 1, new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"), 1, 1, "Схема включения источника регулируемого напряжения" },
                    { new Guid("35dbb6cb-1995-4c91-bc7b-afb5ab67d1bb"), "PictureElement", 1, new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"), 3, 2, "Схема исследования тахогенератора и энкодера" },
                    { new Guid("35fe0914-89f7-4d30-9593-954a291d117a"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 24, 10, "График зависимости I=f(U)" },
                    { new Guid("38049d06-d7ed-4b93-aec9-f69a241f0e87"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 14, 6, "График зависимости U2=f(U1)" },
                    { new Guid("615b3580-c5cc-46a6-803a-28fac78e3826"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 21, 9, "Схема исследования датчика напряжения на эффекте Холла" },
                    { new Guid("7319c51b-c891-424d-bc27-127f7105c560"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 16, 7, "Схема исследования датчика тока на эффекте Холла" },
                    { new Guid("987b0e05-313b-4ab9-8881-6350cbecdce3"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 1, 1, "Схема исследования шунта" },
                    { new Guid("d5e8c092-777e-46da-ad84-26f4ab0ab4b4"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 9, 4, "График зависимости I2=f(I1)" },
                    { new Guid("e17972fa-2bf6-4fa6-a7c3-bb24835549d9"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 4, 2, "График зависимости Uш=f(Iн)" },
                    { new Guid("fee1c284-cd16-4a86-9b13-a2354b02f500"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 6, 3, "Схема исследования трансформатора тока" }
                });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "ColumnsCount", "Discriminator", "ElementType", "HorizontalTitles", "LabTemplateId", "Number", "RowsCount", "TableNumber", "Text", "VerticalTitles" },
                values: new object[,]
                {
                    { new Guid("390df32c-bdba-4f43-8b6c-dad951c8b88a"), 12, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 22, 2, 5, "Данные эксперимента", "U,В;I,мА" },
                    { new Guid("53181238-f215-4b14-bef9-f288bbbc4eca"), 12, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 12, 2, 3, "Данные эксперимента", "U1,В;U2,В" },
                    { new Guid("5bbe836b-cf34-4bbf-96c4-c9badada3e2a"), 5, "TableElement", 2, "№ п/п;U1;Uг,В;n,об/мин;nг,об/мин", new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"), 5, 13, 1, "Данные эксперимента", null },
                    { new Guid("9af2eff0-e703-4144-aabe-a9bf40efcfb8"), 9, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 7, 2, 2, "Данные эксперимента", "I1,мА;I2,мА" },
                    { new Guid("b0a5b848-e493-4186-a6c2-7d51c1609035"), 12, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 2, 3, 1, "Данные эксперимента", "Uш,мВ;Iн,А;Iш,А" },
                    { new Guid("d2e6470b-0c02-451f-824d-49eee808868d"), 10, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 17, 2, 4, "Данные эксперимента", "I1,А;I2,мА" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaf4a7d4-6ddf-40ff-8e36-5533f5c1e4a9");

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("0bb3286a-2129-417e-911c-e9cb6adec781"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("176ca2cb-45c4-4305-8db3-24d61d8215dd"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("215596ee-3852-47e6-9220-ed1697eb1824"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("23277a97-9df3-44a3-a6c9-18823052830f"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("549b288b-80fe-44b9-937c-570054fe1b05"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("6efd4fc8-b664-43e8-82e3-3ecb216ccf0d"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("7adf8355-6e51-44a9-a30f-616ab77a23e5"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("971c7491-7f53-440f-94c8-484132325a4e"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("d46fffaa-fd6a-40e0-9fb0-d2e4fd58b33e"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("d8d6126e-dbea-4942-a1e4-c4df5bdeea6f"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("e7a8aca1-865c-40b4-8a1b-8131126273c7"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("ea88a7b8-a143-47cc-90af-b0bde1869596"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("f59bafb9-0ab4-47da-b97b-fbf53a372a67"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("0e4eed54-121b-4309-99e4-4e46bf9fea9b"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("0f4fcee3-a05e-4f59-96b9-f8dc185a28b5"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("28aaf1f5-41c7-432c-935f-f773315c15d8"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("35dbb6cb-1995-4c91-bc7b-afb5ab67d1bb"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("35fe0914-89f7-4d30-9593-954a291d117a"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("38049d06-d7ed-4b93-aec9-f69a241f0e87"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("615b3580-c5cc-46a6-803a-28fac78e3826"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("7319c51b-c891-424d-bc27-127f7105c560"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("987b0e05-313b-4ab9-8881-6350cbecdce3"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("d5e8c092-777e-46da-ad84-26f4ab0ab4b4"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("e17972fa-2bf6-4fa6-a7c3-bb24835549d9"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("fee1c284-cd16-4a86-9b13-a2354b02f500"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("390df32c-bdba-4f43-8b6c-dad951c8b88a"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("53181238-f215-4b14-bef9-f288bbbc4eca"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("5bbe836b-cf34-4bbf-96c4-c9badada3e2a"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("9af2eff0-e703-4144-aabe-a9bf40efcfb8"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("b0a5b848-e493-4186-a6c2-7d51c1609035"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("d2e6470b-0c02-451f-824d-49eee808868d"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "60bb650d-391a-47cc-a9cd-e6452976898f", "58784572-464d-4d69-96d8-423cea3b3ee7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "Discriminator", "ElementType", "LabTemplateId", "Number", "Text" },
                values: new object[,]
                {
                    { new Guid("075c375f-7a09-48e4-ba50-4da0a665ecd9"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 13, "\n          3.2.Строим статическую характеристику U2=f(U1)." },
                    { new Guid("213b95c9-9c4e-4cc4-a822-32e3c0757e60"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 3, "          где Iш=Uш/Rш, Rш=100 мОм\n\n          1.2.Строим статическую характеристику Uш=f(Iн)." },
                    { new Guid("2c31d8b0-a296-4cb2-8445-f4551ab37948"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 20, "\n          5. Исследование датчика напряжения на эффекте Холла.\n          5.1. Собираем схему на рис.9 и снимаем значения U и I." },
                    { new Guid("52587545-7936-4761-b602-28f62b41bc52"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 15, "\n          4. Исследование датчика тока на эффекте Холла.\n          4.1. Собираем схему на рис.7 и снимаем значения I1 и I2." },
                    { new Guid("8811f813-d0fa-47ae-a2b0-95121901772f"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 23, "\n          5.2.Строим статическую характеристику I=f(U)." },
                    { new Guid("a90009db-809c-4d67-a15c-80b5865aae48"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 8, "\n          2.2.Строим статическую характеристику I2=f(I1)." },
                    { new Guid("b08dfa52-02ab-4356-919b-5a34c26f0954"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 5, "\n          2.Исследование трансформатора тока.\n          2.1.Собираем схему на рис.3 и снимаем значения I1 и I2." },
                    { new Guid("c6e61783-53da-4a8b-a463-4160368d0270"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 0, "          1. Исследование шунта.\n          1.1. Собираем схему на рис.1 и снимаем значения Uш и Iн." },
                    { new Guid("e558e12b-9d38-46b2-97e9-8a70ac7a0713"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 18, "\n          4.2.Строим статическую характеристику I2=f(I1)." },
                    { new Guid("efb4b48e-19b9-4810-a164-56872b734f14"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 10, "\n          3. Исследование измерительного трансформатора напряжения.\n          3.1. Собираем схему на рис.5 и снимаем значения U1 и U2." }
                });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "Discriminator", "ElementType", "LabTemplateId", "Number", "PictureNumber", "Text" },
                values: new object[,]
                {
                    { new Guid("2651fded-caaf-4096-b8cb-2642be45fa18"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 19, 8, "График зависимости I2=f(I1)" },
                    { new Guid("2d672f99-7ca5-420b-98a5-2dfc028f0e49"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 16, 7, "Схема исследования датчика тока на эффекте Холла" },
                    { new Guid("37226d0e-7681-4dd4-ad05-a112feedc754"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 11, 5, "Схема исследования трансформатора напряжения" },
                    { new Guid("414f9b63-ec69-41c9-98a0-5e2ee3dd1ef1"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 9, 4, "График зависимости I2=f(I1)" },
                    { new Guid("72d8f395-b14c-4e0d-8cc4-a0d40bdc9010"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 6, 3, "Схема исследования трансформатора тока" },
                    { new Guid("7a0eab93-25c1-49a3-b1c7-72daa2afb8bc"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 14, 6, "График зависимости U2=f(U1)" },
                    { new Guid("8b007e14-7cf7-4775-be4a-95496b04d756"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 4, 2, "График зависимости Uш=f(Iн)" },
                    { new Guid("a6ec28a2-14fa-4f4c-908e-d7515964db3b"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 1, 1, "Схема исследования шунта" },
                    { new Guid("d59c841f-a25f-4c57-9da1-db8101ea7fdf"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 24, 10, "График зависимости I=f(U)" },
                    { new Guid("dba05c5d-2117-4aa7-bc4b-b0d9edc1ca90"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 21, 9, "Схема исследования датчика напряжения на эффекте Холла" }
                });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "ColumnsCount", "Discriminator", "ElementType", "HorizontalTitles", "LabTemplateId", "Number", "RowsCount", "TableNumber", "Text", "VerticalTitles" },
                values: new object[,]
                {
                    { new Guid("6e5960cc-329a-45e4-a16c-ec01b6af9f1f"), 12, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 22, 2, 5, "Данные эксперимента", "U,В;I,мА" },
                    { new Guid("7c7caf3f-f434-4ed8-ad01-e73e8ede9c20"), 12, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 2, 3, 1, "Данные эксперимента", "Uш,мВ;Iн,А;Iш,А" },
                    { new Guid("8f4cd9e7-e2e8-44bb-9350-6d674ef24c79"), 12, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 12, 2, 3, "Данные эксперимента", "U1,В;U2,В" },
                    { new Guid("a9e7c479-ec78-4b40-a995-4c1a9619a27a"), 9, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 7, 2, 2, "Данные эксперимента", "I1,мА;I2,мА" },
                    { new Guid("fc0bba91-22c7-4005-bddc-c7acaefd3879"), 10, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 17, 2, 4, "Данные эксперимента", "I1,А;I2,мА" }
                });
        }
    }
}

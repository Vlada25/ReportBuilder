using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReportBuilder.DAL.Migrations
{
    public partial class ChangeSomeDataForLab3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "6f6d24e8-098a-498f-8a91-cb058a3c353b", "897583ea-6382-4890-996e-092a19523e65", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "Discriminator", "ElementType", "LabTemplateId", "Number", "Text" },
                values: new object[,]
                {
                    { new Guid("073b4b06-fc5a-43b9-803a-3d0ee30a5774"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 10, "\n          3. Исследование измерительного трансформатора напряжения.\n          3.1. Собираем схему на рис.5 и снимаем значения U1 и U2." },
                    { new Guid("2208d70f-9af6-4a55-8a1f-71fe340c09fb"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 13, "\n          3.2.Строим статическую характеристику U2=f(U1)." },
                    { new Guid("2ff390d7-1354-4877-a3cd-66cccdd699cd"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 20, "\n          5. Исследование датчика напряжения на эффекте Холла.\n          5.1. Собираем схему на рис.9 и снимаем значения U и I." },
                    { new Guid("318ecc95-e2b3-44b6-bc06-5315166e036b"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 3, "          где Iш=Uш/Rш, Rш=100 мОм\n\n          1.2.Строим статическую характеристику Uш=f(Iн)." },
                    { new Guid("3fc3b9f6-58ea-4894-86da-335cfa287b30"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 23, "\n          5.2.Строим статическую характеристику I=f(U)." },
                    { new Guid("55bc5467-e2ec-4ff0-983b-d0a30fd28d9a"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 18, "\n          4.2.Строим статическую характеристику I2=f(I1)." },
                    { new Guid("7d18984d-fff8-4655-aaa7-b18cf48e326f"), "ParagraphElement", 0, new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"), 0, "          1. Подключаем стенд к однофазной сети переменного тока 220В, 50Гц.\n          2. Собираем схему источника регулируемого напряжения, как показано на рисунке 1." },
                    { new Guid("81ea1d02-eda2-4202-981d-73fa9144549b"), "ParagraphElement", 0, new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"), 2, "\n          3. Подключаем мультиметр к гнездам тахогенератора BR1 и двигателя M1, как показано на рисунке 2. Выставляем пределы измерения 20В и 200В постоянного напряжения соответственно." },
                    { new Guid("9dc9e86d-dd64-4756-ac05-53ec6b9ff2ca"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 5, "\n          2.Исследование трансформатора тока.\n          2.1.Собираем схему на рис.3 и снимаем значения I1 и I2." },
                    { new Guid("a50ab1ad-c414-43a7-a268-fb5dc3fd0203"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 0, "          1. Исследование шунта.\n          1.1. Собираем схему на рис.1 и снимаем значения Uш и Iн." },
                    { new Guid("ea208cfa-afec-4d25-b49d-66b6fd41652e"), "ParagraphElement", 0, new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"), 4, "\n          4. Регистрируем значение частоты вращения n на приборе EP1 и значение выходного напряжения Uг на тахогенераторе. Полученные данные заносим в таблицу 1." },
                    { new Guid("fc846cf7-1200-4066-aa97-eb342274ea21"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 8, "\n          2.2.Строим статическую характеристику I2=f(I1)." },
                    { new Guid("fe978b13-10fe-419d-9567-a2039a7279a2"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 15, "\n          4. Исследование датчика тока на эффекте Холла.\n          4.1. Собираем схему на рис.7 и снимаем значения I1 и I2." }
                });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "Discriminator", "ElementType", "LabTemplateId", "Number", "PictureNumber", "Text" },
                values: new object[,]
                {
                    { new Guid("0956ed11-1b0d-4f47-a591-0cab180e70e4"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 14, 6, "График зависимости U2=f(U1)" },
                    { new Guid("459cd4f6-7c5f-443a-ade0-dce4a4bff950"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 11, 5, "Схема исследования трансформатора напряжения" },
                    { new Guid("767876ea-39de-44f8-aa67-390f01d30c56"), "PictureElement", 1, new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"), 3, 2, "Схема исследования тахогенератора и энкодера" },
                    { new Guid("7778caa2-ae71-45a7-a645-9db0797f4304"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 1, 1, "Схема исследования шунта" },
                    { new Guid("9af96152-d6af-409b-be07-9adafa367c6b"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 9, 4, "График зависимости I2=f(I1)" },
                    { new Guid("9d6dadf6-8312-4adb-9c21-df07f8f9b0b4"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 24, 10, "График зависимости I=f(U)" },
                    { new Guid("a74c715a-fdd1-40fa-b31d-128ec62da31a"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 16, 7, "Схема исследования датчика тока на эффекте Холла" },
                    { new Guid("b71fd40f-5c7d-4132-99ce-2df23367ae28"), "PictureElement", 1, new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"), 1, 1, "Схема включения источника регулируемого напряжения" },
                    { new Guid("c3412fa2-ae10-4d7d-acfc-1573fc441995"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 19, 8, "График зависимости I2=f(I1)" },
                    { new Guid("c8f3a6b4-86b9-4dca-a721-a4673c37bbcf"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 21, 9, "Схема исследования датчика напряжения на эффекте Холла" },
                    { new Guid("ef0e5361-9d28-492e-9072-5459583c8348"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 6, 3, "Схема исследования трансформатора тока" },
                    { new Guid("fd0e385f-9fc3-4e13-aa36-76a1a1ec629e"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 4, 2, "График зависимости Uш=f(Iн)" }
                });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "ColumnsCount", "Discriminator", "ElementType", "HorizontalTitles", "LabTemplateId", "Number", "RowsCount", "TableNumber", "Text", "VerticalTitles" },
                values: new object[,]
                {
                    { new Guid("678f70ba-b1bc-40a7-bf5f-094ef4d85a22"), 12, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 22, 2, 5, "Данные эксперимента", "U,В;I,мА" },
                    { new Guid("a107d234-7a63-4477-a66d-4383efe9650a"), 9, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 7, 2, 2, "Данные эксперимента", "I1,мА;I2,мА" },
                    { new Guid("a4df223f-7813-4cb3-89b7-d82802b70754"), 12, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 12, 2, 3, "Данные эксперимента", "U1,В;U2,В" },
                    { new Guid("af5adaee-5bf8-405d-931d-2685593ba15f"), 5, "TableElement", 2, "№ п/п;U1;Uг,В;n,об/мин;nг,об/мин", new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"), 5, 13, 1, "Данные эксперимента", null },
                    { new Guid("bfcfaa07-8924-4531-bcfb-76ecef326424"), 10, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 17, 2, 4, "Данные эксперимента", "I1,А;I2,мА" },
                    { new Guid("c59eef27-af8c-4c12-aa80-8f7e9241b986"), 12, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 2, 3, 1, "Данные эксперимента", "Uш,мВ;Iн,А;Iш,А" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f6d24e8-098a-498f-8a91-cb058a3c353b");

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("073b4b06-fc5a-43b9-803a-3d0ee30a5774"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("2208d70f-9af6-4a55-8a1f-71fe340c09fb"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("2ff390d7-1354-4877-a3cd-66cccdd699cd"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("318ecc95-e2b3-44b6-bc06-5315166e036b"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("3fc3b9f6-58ea-4894-86da-335cfa287b30"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("55bc5467-e2ec-4ff0-983b-d0a30fd28d9a"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("7d18984d-fff8-4655-aaa7-b18cf48e326f"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("81ea1d02-eda2-4202-981d-73fa9144549b"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("9dc9e86d-dd64-4756-ac05-53ec6b9ff2ca"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("a50ab1ad-c414-43a7-a268-fb5dc3fd0203"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("ea208cfa-afec-4d25-b49d-66b6fd41652e"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("fc846cf7-1200-4066-aa97-eb342274ea21"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("fe978b13-10fe-419d-9567-a2039a7279a2"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("0956ed11-1b0d-4f47-a591-0cab180e70e4"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("459cd4f6-7c5f-443a-ade0-dce4a4bff950"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("767876ea-39de-44f8-aa67-390f01d30c56"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("7778caa2-ae71-45a7-a645-9db0797f4304"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("9af96152-d6af-409b-be07-9adafa367c6b"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("9d6dadf6-8312-4adb-9c21-df07f8f9b0b4"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("a74c715a-fdd1-40fa-b31d-128ec62da31a"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("b71fd40f-5c7d-4132-99ce-2df23367ae28"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("c3412fa2-ae10-4d7d-acfc-1573fc441995"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("c8f3a6b4-86b9-4dca-a721-a4673c37bbcf"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("ef0e5361-9d28-492e-9072-5459583c8348"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("fd0e385f-9fc3-4e13-aa36-76a1a1ec629e"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("678f70ba-b1bc-40a7-bf5f-094ef4d85a22"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("a107d234-7a63-4477-a66d-4383efe9650a"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("a4df223f-7813-4cb3-89b7-d82802b70754"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("af5adaee-5bf8-405d-931d-2685593ba15f"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("bfcfaa07-8924-4531-bcfb-76ecef326424"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("c59eef27-af8c-4c12-aa80-8f7e9241b986"));

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
    }
}

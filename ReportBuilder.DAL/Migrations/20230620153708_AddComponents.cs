using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReportBuilder.DAL.Migrations
{
    public partial class AddComponents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "aed92411-2ce8-499f-a498-1d5c6e251a37", "4ba2fe85-54d4-4a05-bf55-4110cb526ca4", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "LabsTemplates",
                columns: new[] { "Id", "Conclusion", "Number", "Purpose", "Theme" },
                values: new object[] { new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"), "в ходе лабораторной работы изучил принцип работы термометров сопротивления, экспериментально снял и построил ВАХ терморезистора.", 2, "Исследование характеристик термометров сопротивления, термисторов и термопар.", "Тепловые преобразователи" });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "Discriminator", "ElementType", "LabTemplateId", "Number", "Text" },
                values: new object[,]
                {
                    { new Guid("00efe4ae-f8f9-4c47-8bf1-332d81aa5839"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 15, "\n          4. Исследование датчика тока на эффекте Холла.\n          4.1. Собираем схему на рис.7 и снимаем значения I1 и I2." },
                    { new Guid("0257482d-4abe-4787-b75a-792528044547"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 3, "          где Iш=Uш/Rш, Rш=100 мОм\n\n          1.2.Строим статическую характеристику Uш=f(Iн)." },
                    { new Guid("050397d4-8c8c-47ab-b83a-c25b95398847"), "ParagraphElement", 0, new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 16, "\n          4. Исследование индуктивного датчика линейного перемещения\n          4.1. Подключаем мультиметр к гнездам индуктивного датчика линейного перемещения (рис. 3)." },
                    { new Guid("07a671fd-73f3-4d23-a1b3-98cdc0393f90"), "ParagraphElement", 0, new Guid("8133fde9-ab3a-4e8d-b819-4d543cdfa485"), 5, "\n          7. Характеристика U=f(P)" },
                    { new Guid("0be3be89-404f-4d9a-8448-a0092a5c3c5f"), "ParagraphElement", 0, new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"), 10, "\n          4. Характеристика N=f(α)." },
                    { new Guid("137f053e-e13d-4327-9ac0-46ed721d7d25"), "ParagraphElement", 0, new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 20, "\n          4.3. Строим статическую характеристику Lx=f(X)" },
                    { new Guid("1619fc0b-d0d1-459b-865c-aa984d3dabbe"), "ParagraphElement", 0, new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 10, "\n          3. Исследование ёмкостного датчика линейного перемещения\n          3.1. Подключаем мультиметр к гнездам ёмкостного датчика линейного перемещения (рис. 2)." },
                    { new Guid("199a6a8a-7f9b-4db0-b32e-2e68c913b15b"), "ParagraphElement", 0, new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 24, "\n          5.3. Отодвинем подвижную пластину с экраном вправо от датчика, установив экран на торце подвижной пластины на метке «8» мерной шкалы. Индикатор d показывал расстояние до объекта.\n          5.4. Зафиксируем показания индикатора и сравним со значением мерной шкалы.\n          5.5. Повторим эксперимент, передвинув влево подвижную пластину с экраном влево на следующую метку мерной шкалы. Зафиксируем показания индикатора и сравним со значением мерной шкалы для каждого из положений подвижной пластины с экраном.\n          5.6. Полученные данные занесем в таблицу 5." },
                    { new Guid("205af2cd-f075-48be-8ee2-74d9f260cf8a"), "ParagraphElement", 0, new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 14, "\n          3.3 Строим статическую характеристику Cx=f(X)." },
                    { new Guid("2065a20c-66d1-46c8-957e-07574c60b366"), "ParagraphElement", 0, new Guid("202b2d34-b93e-45db-935b-3a1d050f36bb"), 2, "\n          2. Исследование геркона\n          2.1. Медленно подносить магнит к геркону до момента срабатывания контрольного светодиода.\n          2.2. Оценить расстояние, на котором произошло срабатывание геркона.\n          Срабатывание геркона произошло на расстоянии 1.2 см от магнита.\n          2.3. Сделать выводы о минимальном расстоянии, на котором произошло срабатывание геркона.\n          Благодаря высокой чувствительности геркон можно успешно применять для различных датчиков положения и концевых выключателей. Из недостатков – хрупкая конструкция и намагничивание контактов со временем эксплуатации.\n          3. Исследование оптического датчика\n          3.1. Установить кодовую пластину в корпус оптического датчика.\n          3.2. Передвигать пластину влево/вправо и следить за работой контрольного светодиода.\n          Исходя из измерений, ширина окна оптического датчика составляет 1.6 см (2,4-0,8 см)\n          3.3. Сделать выводы о принципе работы оптического датчика-выключателя.\n          Оптический датчик состоит из источника (излучателя) и приемника оптического излучения, которые могут располагаться в одном или в разных корпусах Датчики такого типа используются для автоматизации любых промышленных процессов, в робототехнике, системах контроля, обработки и монтажа. Из достоинств такого вида датчика можно выделить высокую чувствительность и скорость срабатывания. Из недостатков: не работает в агрессивных средах и в средах с высокой степенью загрязнения.\n          4. Исследование индуктивного датчика\n          4.1. Медленно подвести металлическую пластину к индуктивному датчику, до момента срабатывания контрольного светодиода.\n          Расстояние от датчика, на котором сработал светодиод, составило 0,4 см.\n          4.2. Сделать выводы о минимальном расстоянии, на котором произошло срабатывание индуктивного датчика.\r\n		Поскольку расстояние до срабатывания датчика оказалось существенно мало, по сравнению с герконом, можно сделать вывод о невысокой чувствительности такого датчика. И достоинств можно отметить очень простую конструкцию и возможность работать во всевозможных агрессивных средах." },
                    { new Guid("24319b27-01f7-4460-963e-26d04bef0662"), "ParagraphElement", 0, new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 8, "\n          2.7. Переводим тумблер SB3 в нижнее положение «Транзисторная оптопара».\n          2.8. Повторяем п. 4…6 для транзисторной оптопары и полученные данные заносим в таблицу 2.\n          2.9. Строим статическую характеристику N = f(X) для каждого типа оптопары." },
                    { new Guid("25acacf5-ba17-4717-ab84-a093135828f3"), "ParagraphElement", 0, new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"), 12, "\n                    C. Исследование делителя напряжения\n          1. Подключаем стенд к однофазной сети переменного тока 220В, 50Гц.\n          2. Подключаем мультиметр к гнездам делителя напряжения (рисунок 5). Выставляем предел измерения 20В постоянного напряжения." },
                    { new Guid("286d4683-e7c7-42af-bd8e-ed934ad614d9"), "ParagraphElement", 0, new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"), 16, "\n          5. Характеристика U=f(α)" },
                    { new Guid("2d278fa9-f3d0-4389-a729-f7a6968ac3c0"), "ParagraphElement", 0, new Guid("8133fde9-ab3a-4e8d-b819-4d543cdfa485"), 3, "\n          3. Перевести автоматический выключатель «СЕТЬ» в верхнее положение.\n          4. Убедиться, что регулятор давления закрыт. Для этого вытянуть ручку на себя и повернуть влево до упора. Затем потянуть ручку регулятора давления от себя, убедиться, что ручка зафиксирована.\n          5. Перевести переключатель SB5 в верхнее положение («1») для включения воздушного компрессора. Когда давление воздуха в ресивере достигнет 0,6 МПа (контролировать по манометру), выключить воздушный компрессор переводом переключателя SB5 в нижнее положение («0»).\n          6. Вытянуть ручку регулятора давления на себя и поворотом ручки вправо плавно стравливать давление воздуха из ресивера. При этом регистрировать по манометру давление P, а по мультиметру напряжение U датчика давления. Полученные данные занести в таблицу 1." },
                    { new Guid("3168739f-33e7-458b-8678-17526a6bebb2"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 0, "          1. Исследование шунта.\n          1.1. Собираем схему на рис.1 и снимаем значения Uш и Iн." },
                    { new Guid("45664397-d235-43e3-96ce-d26a2b03bb51"), "ParagraphElement", 0, new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 18, "\n          4.2. Передвигаем ферритовый сердечник влево, регистрируя значения индуктивности катушки и перемещения сердечника. Полученные данные заносим в таблицу 4." },
                    { new Guid("459492d9-662e-46e3-9edd-78a6b57823dc"), "ParagraphElement", 0, new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 12, "\n          3.2 Передвигаем пластину датчика ручкой вправо, регистрируя значения емкости и перемещения. Полученные данные заносим в таблицу 3." },
                    { new Guid("4c05c923-c1cc-4ca3-94b9-c8a5cc39aff8"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 5, "\n          2.Исследование трансформатора тока.\n          2.1.Собираем схему на рис.3 и снимаем значения I1 и I2." },
                    { new Guid("51bd62ec-1189-4197-83f7-a3c99816a661"), "ParagraphElement", 0, new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 0, "\n          1. Исследование резистивного датчика линейного перемещения\n          1.1. Подключаем мультиметр к гнёздам резистивного датчика (рис. 1).\nВыставляем предел измерения 200 кОм." },
                    { new Guid("54f34e3d-bac1-425f-a33d-ae38d6cd6b5d"), "ParagraphElement", 0, new Guid("202b2d34-b93e-45db-935b-3a1d050f36bb"), 0, "\n          1. Исследование бесконтактных датчиков-выключателей\n          1.1. Подключить стенд к однофазной сети переменного тока 220В, 50Гц.\n          1.2. Перевести автоматический выключатель «СЕТЬ» в верхнее положение." },
                    { new Guid("57074299-0f94-48c9-8d55-1915c6f92c8d"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 20, "\n          5. Исследование датчика напряжения на эффекте Холла.\n          5.1. Собираем схему на рис.9 и снимаем значения U и I." },
                    { new Guid("574ea321-5549-4d9b-a874-7f46e0d48947"), "ParagraphElement", 0, new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 22, "\n          5. Исследование ультразвукового датчика линейного перемещения\n          5.1. Подключаем стенд к однофазной сети переменного тока 220В, 50Гц.\n          5.2. Переводим автоматический выключатель «СЕТЬ» в верхнее положение." },
                    { new Guid("687824d1-225f-4961-9095-6254304f0a8f"), "ParagraphElement", 0, new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"), 0, "          1. Подключаем стенд к однофазной сети переменного тока 220В, 50Гц.\n          2. Собираем схему источника регулируемого напряжения, как показано на рисунке 1." },
                    { new Guid("6a1a09a1-9578-43b8-99ca-ffb62a8bba32"), "ParagraphElement", 0, new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"), 6, "\n          5. Строим экспериментальную характеристику Uг = f(n)." },
                    { new Guid("6b3e7c3f-675f-4214-a58c-cde985b0a1b0"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 8, "\n          2.2.Строим статическую характеристику I2=f(I1)." },
                    { new Guid("6c9d9841-92d0-4395-8195-1d328aa175f7"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 10, "\n          3. Исследование измерительного трансформатора напряжения.\n          3.1. Собираем схему на рис.5 и снимаем значения U1 и U2." },
                    { new Guid("7f4cbc00-3f81-4b0d-a968-5920d0b4390d"), "ParagraphElement", 0, new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 4, "\n          1.3 Строим статическую характеристику R = f(X)." },
                    { new Guid("80fa7aeb-1362-4f2e-97ec-4042e747289c"), "ParagraphElement", 0, new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"), 2, "\n          2. Регулятором потенциометра изменяем угол поворота α и регистрируем показания сопротивления R. Полученные данные заносим в таблицу 1." },
                    { new Guid("8514add9-2219-43c8-8c42-7979ee59eeb5"), "ParagraphElement", 0, new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"), 4, "\n          3. Характеристика R=f(α)" },
                    { new Guid("8602c8c1-830b-42bb-a5b2-c101cfb1b7df"), "ParagraphElement", 0, new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"), 2, "\n          2. Рассчитываем значение сопротивления терморезистора при температуре 100°C^\nW = R100/R0\nR100 = R0 * W = 50 * 1.428 = 71.4 Ом\nНайдём значения сопротивления терморезистора при различных значениях температуры. Для этого сначала определим коэффициент a:\nR = R0 * (1 + a * T)\na = (R/R0 - 1)/T = 0.00428" },
                    { new Guid("95ea9c97-df79-4047-b5b8-e7c67c2ef1e3"), "ParagraphElement", 0, new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"), 2, "\n          3. Подключаем мультиметр к гнездам тахогенератора BR1 и двигателя M1, как показано на рисунке 2. Выставляем пределы измерения 20В и 200В постоянного напряжения соответственно." },
                    { new Guid("a167dc7a-23f5-418d-a55c-a60b0c983ec6"), "ParagraphElement", 0, new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 2, "\n          1.2 Перемещая ползунок резистора вправо, регистрируем значения сопротивления R и перемещая X. Полученные данные заносим в таблицу 1." },
                    { new Guid("a230342f-dfdc-4afb-924d-8eac39e622ae"), "ParagraphElement", 0, new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"), 4, "\n          4. Регистрируем значение частоты вращения n на приборе EP1 и значение выходного напряжения Uг на тахогенераторе. Полученные данные заносим в таблицу 1." },
                    { new Guid("a3a357bb-2e13-4c86-8ae8-adefcca3e89f"), "ParagraphElement", 0, new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 6, "\n          2. Исследование оптоэлектрического датчика линейного перемещения.\n          2.1. Подключаем стенд к однофазной сети переменного тока 220В, 50Гц.\n          2.2. Вставляем кодовую линейку в отверстие.\n          2.3. Переводим автоматический выключатель «СЕТЬ» в верхнее положение.\n          2.4. Выставляем кодовую линейку на нулевое значение. При необходимости можно сбросить показания счетчика нажатием кнопки SB4.\n          2.5. Переводим тумблер SB3 в верхнее положение «Диодная оптопара».\n          2.6. Передвигаем кодовую линейку вправо, регистрируем количество «шагов» N и перемещение X. Полученные данные заносим в таблицу 2." },
                    { new Guid("adf57363-3da2-424d-97ee-d1de27d0c379"), "ParagraphElement", 0, new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"), 14, "\n          3. Переводим автоматический выключатель «СЕТЬ» в верхнее положение.\n          4. Регулятором потенциометра изменяем угол поворота α и регистрируем показания напряжения U. Полученные данные заносим в таблицу 3." },
                    { new Guid("b0dbebea-5ced-4f7a-89b0-a760ed3235d4"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 18, "\n          4.2.Строим статическую характеристику I2=f(I1)." },
                    { new Guid("c196cae7-66a8-4945-8060-adf978ab4cb9"), "ParagraphElement", 0, new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"), 6, "\nгде Iш = Uш/Rш, Rш = 750 Ом\nЗначение напряжения на терморезисторе: U = Iш * Rт." },
                    { new Guid("c416058e-a916-4ba8-80ff-bc93c79405f8"), "ParagraphElement", 0, new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"), 6, "\n                    B. Исследование цифрового датчика угла\n          1. Подключаем стенд к однофазной сети переменного тока 220В, 50Гц.\n          2. Переводим автоматический выключатель «СЕТЬ» в верхнее положение.\r\n" },
                    { new Guid("c8243c64-d417-4235-b14f-6936a5849797"), "ParagraphElement", 0, new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"), 4, "\n          3. Снимаем показания вольтметра и рассчитываем значение напряжения на терморезисторе." },
                    { new Guid("ca0d626a-4443-41ee-907a-ae8e871e15dd"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 13, "\n          3.2.Строим статическую характеристику U2=f(U1)." }
                });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "Discriminator", "ElementType", "LabTemplateId", "Number", "Text" },
                values: new object[,]
                {
                    { new Guid("ccec6b63-ce69-460c-a594-b429e3adf7fd"), "ParagraphElement", 0, new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"), 8, "\n          4. Строим вольт-амперную характеристику терморезистора." },
                    { new Guid("ce48b660-b8d2-4f88-a913-154ef39b01fd"), "ParagraphElement", 0, new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"), 0, "\n                    A. Исследование потенциометра\n          1. Подключаем мультиметр к гнездам потенциометра (рисунок 1). Выставляем предел измерения 20кОм." },
                    { new Guid("dbf79d85-a1ab-4854-928d-ddfd27f10b07"), "ParagraphElement", 0, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 23, "\n          5.2.Строим статическую характеристику I=f(U)." },
                    { new Guid("ddcd445b-4717-4474-b0bb-325a7693b671"), "ParagraphElement", 0, new Guid("8133fde9-ab3a-4e8d-b819-4d543cdfa485"), 0, "\n          1. Подключаем стенд к однофазной сети переменного тока 220В, 50Гц.\n          2. Подключить мультиметр к гнездам датчика давления (рисунок 1). Выставить предел измерения 200мВ постоянного напряжения." },
                    { new Guid("de78783a-6466-4821-8739-d9c05448850c"), "ParagraphElement", 0, new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"), 0, "          1. Схема эксперимента:" },
                    { new Guid("e4953ea6-c3ee-48d0-b671-ce91b30194a3"), "ParagraphElement", 0, new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"), 8, "\n          6. Находим теоретическую скорость вращения тахогенератора nг, из расчёта 1В = 870 об/мин.\nnг = 870 * Uг\nВсе расчитанные данные заносим в таблицу 1.\n          7. Сравнивая показания скорости вращения тахогенератора nг и энкодера n можно заметить небольшие расхождения." },
                    { new Guid("f761421d-9466-4a27-b77e-ec18239cc2d8"), "ParagraphElement", 0, new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"), 8, "\n          3. Регулятором переключателя изменяем угол поворота α и регистрируем показания комбинаций светодиодов N. Полученные данные заносим в таблицу 2." }
                });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "Discriminator", "ElementType", "LabTemplateId", "Number", "PictureNumber", "Text" },
                values: new object[,]
                {
                    { new Guid("0805a1d7-2b54-4a5a-8d58-68604d486365"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 21, 9, "Схема исследования датчика напряжения на эффекте Холла" },
                    { new Guid("14dc0183-e0c0-4512-968d-7191b0ea2953"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 16, 7, "Схема исследования датчика тока на эффекте Холла" },
                    { new Guid("235f2de6-9fe8-4a6a-825a-f3ebeab78a0f"), "PictureElement", 1, new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 15, 5, "Статическая характеристика Cx = f(X)." },
                    { new Guid("26d8cc77-4ec9-4e1d-848c-0409c5c16af7"), "PictureElement", 1, new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"), 13, 5, "Схема подключения мультиметра для исследования делителя напряжения." },
                    { new Guid("293485fa-b13c-4484-9644-c37123a6b791"), "PictureElement", 1, new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 23, 8, "Схема исследования ультразвукового датчика линейного перемещения" },
                    { new Guid("2ffe3e49-7282-479e-ac78-c27da48da340"), "PictureElement", 1, new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"), 11, 4, "Характеристика N=f(α)." },
                    { new Guid("36eb1036-a5b9-46af-8e22-4595975a49d5"), "PictureElement", 1, new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 9, 3, "Статическая характеристика N = f(X)." },
                    { new Guid("3807a95c-d242-444e-928c-fbbdd13ff43f"), "PictureElement", 1, new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 21, 7, "Статическая характеристика Lx =f(X)" },
                    { new Guid("3d88fef1-76db-4fe2-80db-401b0e446b94"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 19, 8, "График зависимости I2=f(I1)" },
                    { new Guid("40a0c4f2-f230-45b4-b541-456ca1301a06"), "PictureElement", 1, new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"), 1, 1, "Схема исследования терморезистора" },
                    { new Guid("415bc684-284c-4211-8919-2932cd49b12e"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 1, 1, "Схема исследования шунта" },
                    { new Guid("4aed1d07-a9b4-47e1-9bee-14b925353260"), "PictureElement", 1, new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 5, 2, "Статическая характеристика R = f(X)." },
                    { new Guid("56f02f46-3223-4998-a470-c15d964ba1af"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 6, 3, "Схема исследования трансформатора тока" },
                    { new Guid("5f6b1487-7337-44c8-a59e-abdf803cc9e9"), "PictureElement", 1, new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"), 1, 1, "Схема включения источника регулируемого напряжения" },
                    { new Guid("7cdea744-2705-4412-afb0-9c5bc113b908"), "PictureElement", 1, new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"), 9, 2, "ВАХ терморезистора" },
                    { new Guid("7ddaf596-c283-43cc-9ec2-1968674d9090"), "PictureElement", 1, new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"), 5, 2, "Характеристика R=f(α)" },
                    { new Guid("83178151-277c-4d86-a630-6f0da3481238"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 11, 5, "Схема исследования трансформатора напряжения" },
                    { new Guid("8ea7771a-ac7d-4768-a251-ac5fb5893445"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 14, 6, "График зависимости U2=f(U1)" },
                    { new Guid("9037ac69-7354-4c0b-810d-c6a6227289aa"), "PictureElement", 1, new Guid("8133fde9-ab3a-4e8d-b819-4d543cdfa485"), 2, 2, "Установка для исследования датчика давления." },
                    { new Guid("90ac2dfb-e076-4d4c-8a92-c0b6fcd8e942"), "PictureElement", 1, new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"), 17, 6, "Характеристика U=f(α)." },
                    { new Guid("91950664-dffe-496b-bf10-95f9998db21a"), "PictureElement", 1, new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"), 3, 2, "Схема исследования тахогенератора и энкодера" },
                    { new Guid("95aa80e9-353e-4846-856a-dcd6a3144bd3"), "PictureElement", 1, new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"), 7, 3, "Схема для исследования цифрового датчика угла" },
                    { new Guid("a36de956-4a20-4b7f-8d77-71033fa9bbee"), "PictureElement", 1, new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 17, 6, "Схема подключения мультиметра для исследования индуктивного датчика линейного перемещения" },
                    { new Guid("a4562ae0-9656-4bb3-b05f-ee18e2411bb0"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 9, 4, "График зависимости I2=f(I1)" },
                    { new Guid("a9f64780-130f-4ab8-97a4-14e5632be1e4"), "PictureElement", 1, new Guid("8133fde9-ab3a-4e8d-b819-4d543cdfa485"), 1, 1, "Схема подключения мультиметра для исследования датчика дваления." },
                    { new Guid("ab20e34b-4c0e-463c-a8dc-5ac7d22fce0b"), "PictureElement", 1, new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 1, 1, "Схема включения мультиметра для исследования резистивного датчика линейного перемещения" },
                    { new Guid("b5486b81-2874-4484-be39-6a14441911e9"), "PictureElement", 1, new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"), 1, 1, "Схема подключения мультиметра для исследования потенциометра." },
                    { new Guid("b8f5fce6-ed89-48c9-8b63-9550a4463bba"), "PictureElement", 1, new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"), 7, 3, "Экспериментальная характеристика Uг = f(n)." },
                    { new Guid("b912bf03-4d86-45ed-a7e1-7d104eda8d0f"), "PictureElement", 1, new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 11, 4, "Схема подключения мультиметра для исследования ёмкостного датчика линейного перемещения" },
                    { new Guid("ce6b25d9-093c-4d4d-873f-646fa2e15798"), "PictureElement", 1, new Guid("8133fde9-ab3a-4e8d-b819-4d543cdfa485"), 6, 3, "Характеристика U=f(P)." },
                    { new Guid("d6157b45-092d-4f6c-b4ac-ed022211def7"), "PictureElement", 1, new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"), 10, 3, "График T(U)" },
                    { new Guid("d74968db-5b4e-4304-9af0-0271cc4fa080"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 4, 2, "График зависимости Uш=f(Iн)" },
                    { new Guid("df98a9b4-450c-417e-ab14-28b36e2b2e83"), "PictureElement", 1, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 24, 10, "График зависимости I=f(U)" },
                    { new Guid("e6e9e532-1652-452e-9b63-4663e2220e56"), "PictureElement", 1, new Guid("202b2d34-b93e-45db-935b-3a1d050f36bb"), 1, 1, "Блок бесконтактных датчиков-выключателей" }
                });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "ColumnsCount", "Discriminator", "ElementType", "HorizontalTitles", "LabTemplateId", "Number", "RowsCount", "TableNumber", "Text", "VerticalTitles" },
                values: new object[] { new Guid("0c062f83-ae04-4204-b511-a4855fa216e7"), 2, "TableElement", 2, "α, градусы;U, В", new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"), 15, 8, 3, "Экспериментальные данные", null });

            migrationBuilder.InsertData(
                table: "ReportElements",
                columns: new[] { "Id", "ColumnsCount", "Discriminator", "ElementType", "HorizontalTitles", "LabTemplateId", "Number", "RowsCount", "TableNumber", "Text", "VerticalTitles" },
                values: new object[,]
                {
                    { new Guid("22009d04-5487-460a-86a7-b34a9db8ceb0"), 12, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 12, 2, 3, "Данные эксперимента", "U1,В;U2,В" },
                    { new Guid("3982ecfc-0935-40d8-a7fa-fb324ccb343a"), 2, "TableElement", 2, "Ультразвуковой датчик Х, см;Рулетка (линейка) Х, см", new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 25, 7, 5, "Данные эксперимента", null },
                    { new Guid("540fca46-c4cd-4b45-a70f-d5e5be9a6ea1"), 2, "TableElement", 2, "α, градусы;R, кОм", new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"), 3, 11, 1, "Экспериментальные данные", null },
                    { new Guid("5f81d699-6bf4-45fc-91b5-c570cd7617e7"), 9, "TableElement", 2, null, new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"), 5, 3, 2, "Результаты эксперимента", "T,°C;Uш, мВ;Iш, мА" },
                    { new Guid("60a82974-8246-4d52-a6e0-95dcfc4037fb"), 9, "TableElement", 2, null, new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"), 7, 4, 3, "Значения напряженияя на терморезисторе", "T,°C;R, Ом;Iш, мА;U, мВ" },
                    { new Guid("6464ebf7-1876-4cfb-b893-e231fd84b728"), 12, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 2, 3, 1, "Данные эксперимента", "Uш,мВ;Iн,А;Iш,А" },
                    { new Guid("6fbe9dc5-70ff-421c-bfb3-d262de3e2350"), 12, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 22, 2, 5, "Данные эксперимента", "U,В;I,мА" },
                    { new Guid("7bb1e6cc-09d3-4722-aa59-2da868eda42f"), 3, "TableElement", 2, "№ п/п;X, см;Cx, nF", new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 13, 14, 3, "Данные эксперимента", null },
                    { new Guid("80945aaa-7b5c-48fb-9444-97e158a8a193"), 10, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 17, 2, 4, "Данные эксперимента", "I1,А;I2,мА" },
                    { new Guid("88dd7c1c-a5a0-4be3-8d68-9a3ec57bd33c"), 5, "TableElement", 2, "№ п/п;U1;Uг,В;n,об/мин;nг,об/мин", new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"), 5, 13, 1, "Данные эксперимента", null },
                    { new Guid("9b6d03b7-3e50-4e97-b504-c554da9a9b25"), 9, "TableElement", 2, null, new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"), 7, 2, 2, "Данные эксперимента", "I1,мА;I2,мА" },
                    { new Guid("acf4ee63-2856-45fc-a422-0661c7513841"), 2, "TableElement", 2, "Р, МПа;U, мВ", new Guid("8133fde9-ab3a-4e8d-b819-4d543cdfa485"), 4, 13, 1, "Экспериментальные данные", null },
                    { new Guid("c5fec608-fd68-4ed6-a210-255dad15bc82"), 3, "TableElement", 2, "№ п/п;X, см;Lx, mH", new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 19, 10, 4, "Данные эксперимента", null },
                    { new Guid("db849106-f1bd-451f-aa3a-e0fe03cb0b57"), 4, "TableElement", 2, "Диодная оптопара Х, см;Диодная оптопара N, шаг;Транзисторная оптопара Х, см;Транзисторная оптопара N, шаг", new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 7, 9, 2, "Данные эксперимента", null },
                    { new Guid("ef162395-b540-4217-ad8b-eb1819228cc6"), 3, "TableElement", 2, "α, градусы;Комбинация светодиодов;Комбинация в dec", new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"), 9, 11, 2, "Экспериментальные данные", null },
                    { new Guid("efdd92bc-48ea-4687-8754-2b835b651b51"), 9, "TableElement", 2, null, new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"), 3, 2, 1, "Значения сопротивления терморезистора при различных значениях температуры.", "T,°C;R, Ом" },
                    { new Guid("f53c7221-9d19-4166-812d-3790a0468c5b"), 3, "TableElement", 2, "№ п/п;X, см;R, кОм", new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"), 3, 11, 1, "Данные эксперимента", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aed92411-2ce8-499f-a498-1d5c6e251a37");

            migrationBuilder.DeleteData(
                table: "LabsTemplates",
                keyColumn: "Id",
                keyValue: new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("00efe4ae-f8f9-4c47-8bf1-332d81aa5839"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("0257482d-4abe-4787-b75a-792528044547"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("050397d4-8c8c-47ab-b83a-c25b95398847"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("07a671fd-73f3-4d23-a1b3-98cdc0393f90"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("0be3be89-404f-4d9a-8448-a0092a5c3c5f"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("137f053e-e13d-4327-9ac0-46ed721d7d25"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("1619fc0b-d0d1-459b-865c-aa984d3dabbe"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("199a6a8a-7f9b-4db0-b32e-2e68c913b15b"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("205af2cd-f075-48be-8ee2-74d9f260cf8a"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("2065a20c-66d1-46c8-957e-07574c60b366"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("24319b27-01f7-4460-963e-26d04bef0662"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("25acacf5-ba17-4717-ab84-a093135828f3"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("286d4683-e7c7-42af-bd8e-ed934ad614d9"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("2d278fa9-f3d0-4389-a729-f7a6968ac3c0"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("3168739f-33e7-458b-8678-17526a6bebb2"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("45664397-d235-43e3-96ce-d26a2b03bb51"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("459492d9-662e-46e3-9edd-78a6b57823dc"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("4c05c923-c1cc-4ca3-94b9-c8a5cc39aff8"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("51bd62ec-1189-4197-83f7-a3c99816a661"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("54f34e3d-bac1-425f-a33d-ae38d6cd6b5d"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("57074299-0f94-48c9-8d55-1915c6f92c8d"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("574ea321-5549-4d9b-a874-7f46e0d48947"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("687824d1-225f-4961-9095-6254304f0a8f"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("6a1a09a1-9578-43b8-99ca-ffb62a8bba32"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("6b3e7c3f-675f-4214-a58c-cde985b0a1b0"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("6c9d9841-92d0-4395-8195-1d328aa175f7"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("7f4cbc00-3f81-4b0d-a968-5920d0b4390d"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("80fa7aeb-1362-4f2e-97ec-4042e747289c"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("8514add9-2219-43c8-8c42-7979ee59eeb5"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("8602c8c1-830b-42bb-a5b2-c101cfb1b7df"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("95ea9c97-df79-4047-b5b8-e7c67c2ef1e3"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("a167dc7a-23f5-418d-a55c-a60b0c983ec6"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("a230342f-dfdc-4afb-924d-8eac39e622ae"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("a3a357bb-2e13-4c86-8ae8-adefcca3e89f"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("adf57363-3da2-424d-97ee-d1de27d0c379"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("b0dbebea-5ced-4f7a-89b0-a760ed3235d4"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("c196cae7-66a8-4945-8060-adf978ab4cb9"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("c416058e-a916-4ba8-80ff-bc93c79405f8"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("c8243c64-d417-4235-b14f-6936a5849797"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("ca0d626a-4443-41ee-907a-ae8e871e15dd"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("ccec6b63-ce69-460c-a594-b429e3adf7fd"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("ce48b660-b8d2-4f88-a913-154ef39b01fd"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("dbf79d85-a1ab-4854-928d-ddfd27f10b07"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("ddcd445b-4717-4474-b0bb-325a7693b671"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("de78783a-6466-4821-8739-d9c05448850c"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("e4953ea6-c3ee-48d0-b671-ce91b30194a3"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("f761421d-9466-4a27-b77e-ec18239cc2d8"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("0805a1d7-2b54-4a5a-8d58-68604d486365"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("14dc0183-e0c0-4512-968d-7191b0ea2953"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("235f2de6-9fe8-4a6a-825a-f3ebeab78a0f"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("26d8cc77-4ec9-4e1d-848c-0409c5c16af7"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("293485fa-b13c-4484-9644-c37123a6b791"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("2ffe3e49-7282-479e-ac78-c27da48da340"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("36eb1036-a5b9-46af-8e22-4595975a49d5"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("3807a95c-d242-444e-928c-fbbdd13ff43f"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("3d88fef1-76db-4fe2-80db-401b0e446b94"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("40a0c4f2-f230-45b4-b541-456ca1301a06"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("415bc684-284c-4211-8919-2932cd49b12e"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("4aed1d07-a9b4-47e1-9bee-14b925353260"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("56f02f46-3223-4998-a470-c15d964ba1af"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("5f6b1487-7337-44c8-a59e-abdf803cc9e9"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("7cdea744-2705-4412-afb0-9c5bc113b908"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("7ddaf596-c283-43cc-9ec2-1968674d9090"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("83178151-277c-4d86-a630-6f0da3481238"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("8ea7771a-ac7d-4768-a251-ac5fb5893445"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("9037ac69-7354-4c0b-810d-c6a6227289aa"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("90ac2dfb-e076-4d4c-8a92-c0b6fcd8e942"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("91950664-dffe-496b-bf10-95f9998db21a"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("95aa80e9-353e-4846-856a-dcd6a3144bd3"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("a36de956-4a20-4b7f-8d77-71033fa9bbee"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("a4562ae0-9656-4bb3-b05f-ee18e2411bb0"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("a9f64780-130f-4ab8-97a4-14e5632be1e4"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("ab20e34b-4c0e-463c-a8dc-5ac7d22fce0b"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("b5486b81-2874-4484-be39-6a14441911e9"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("b8f5fce6-ed89-48c9-8b63-9550a4463bba"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("b912bf03-4d86-45ed-a7e1-7d104eda8d0f"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("ce6b25d9-093c-4d4d-873f-646fa2e15798"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("d6157b45-092d-4f6c-b4ac-ed022211def7"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("d74968db-5b4e-4304-9af0-0271cc4fa080"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("df98a9b4-450c-417e-ab14-28b36e2b2e83"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("e6e9e532-1652-452e-9b63-4663e2220e56"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("0c062f83-ae04-4204-b511-a4855fa216e7"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("22009d04-5487-460a-86a7-b34a9db8ceb0"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("3982ecfc-0935-40d8-a7fa-fb324ccb343a"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("540fca46-c4cd-4b45-a70f-d5e5be9a6ea1"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("5f81d699-6bf4-45fc-91b5-c570cd7617e7"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("60a82974-8246-4d52-a6e0-95dcfc4037fb"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("6464ebf7-1876-4cfb-b893-e231fd84b728"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("6fbe9dc5-70ff-421c-bfb3-d262de3e2350"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("7bb1e6cc-09d3-4722-aa59-2da868eda42f"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("80945aaa-7b5c-48fb-9444-97e158a8a193"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("88dd7c1c-a5a0-4be3-8d68-9a3ec57bd33c"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("9b6d03b7-3e50-4e97-b504-c554da9a9b25"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("acf4ee63-2856-45fc-a422-0661c7513841"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("c5fec608-fd68-4ed6-a210-255dad15bc82"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("db849106-f1bd-451f-aa3a-e0fe03cb0b57"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("ef162395-b540-4217-ad8b-eb1819228cc6"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("efdd92bc-48ea-4687-8754-2b835b651b51"));

            migrationBuilder.DeleteData(
                table: "ReportElements",
                keyColumn: "Id",
                keyValue: new Guid("f53c7221-9d19-4166-812d-3790a0468c5b"));

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
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReportBuilder.DAL.Common;
using ReportBuilder.DAL.Enums;
using ReportBuilder.DAL.Models.ReportElements;

namespace ReportBuilder.DAL.Configuration
{
    public class ParagraphElementConfig : IEntityTypeConfiguration<ParagraphElement>
    {
        public void Configure(EntityTypeBuilder<ParagraphElement> builder)
        {
            builder.HasData(new List<ParagraphElement>
            {
                // -------------------------------------------
                // Lab 1
                // -------------------------------------------
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 0,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"{Constants.Tab}1. Исследование шунта.\n{Constants.Tab}1.1. Собираем схему на рис.1 и снимаем значения Uш и Iн."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 3,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"{Constants.Tab}где Iш=Uш/Rш, Rш=100 мОм\n\n{Constants.Tab}1.2.Строим статическую характеристику Uш=f(Iн)."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 5,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}2.Исследование трансформатора тока.\n{Constants.Tab}2.1.Собираем схему на рис.3 и снимаем значения I1 и I2."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 8,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}2.2.Строим статическую характеристику I2=f(I1)."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 10,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}3. Исследование измерительного трансформатора напряжения.\n{Constants.Tab}3.1. Собираем схему на рис.5 и снимаем значения U1 и U2."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 13,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}3.2.Строим статическую характеристику U2=f(U1)."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 15,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}4. Исследование датчика тока на эффекте Холла.\n{Constants.Tab}4.1. Собираем схему на рис.7 и снимаем значения I1 и I2."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 18,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}4.2.Строим статическую характеристику I2=f(I1)."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 20,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}5. Исследование датчика напряжения на эффекте Холла.\n{Constants.Tab}5.1. Собираем схему на рис.9 и снимаем значения U и I."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 23,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}5.2.Строим статическую характеристику I=f(U)."
                },

                // -------------------------------------------
                // Lab 2
                // -------------------------------------------
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"),
                    Number = 0,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"{Constants.Tab}1. Схема эксперимента:"
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"),
                    Number = 2,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}2. Рассчитываем значение сопротивления терморезистора при температуре 100°C^\nW = R100/R0\nR100 = R0 * W = 50 * 1.428 = 71.4 Ом\nНайдём значения сопротивления терморезистора при различных значениях температуры. Для этого сначала определим коэффициент a:\nR = R0 * (1 + a * T)\na = (R/R0 - 1)/T = 0.00428"
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"),
                    Number = 4,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}3. Снимаем показания вольтметра и рассчитываем значение напряжения на терморезисторе."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"),
                    Number = 6,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\nгде Iш = Uш/Rш, Rш = 750 Ом\nЗначение напряжения на терморезисторе: U = Iш * Rт."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"),
                    Number = 8,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}4. Строим вольт-амперную характеристику терморезистора."
                },

                // -------------------------------------------
                // Lab 3
                // -------------------------------------------
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"),
                    Number = 0,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"{Constants.Tab}1. Подключаем стенд к однофазной сети переменного тока 220В, 50Гц.\n{Constants.Tab}2. Собираем схему источника регулируемого напряжения, как показано на рисунке 1."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"),
                    Number = 2,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}3. Подключаем мультиметр к гнездам тахогенератора BR1 и двигателя M1, как показано на рисунке 2. Выставляем пределы измерения 20В и 200В постоянного напряжения соответственно."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"),
                    Number = 4,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}4. Регистрируем значение частоты вращения n на приборе EP1 и значение выходного напряжения Uг на тахогенераторе. Полученные данные заносим в таблицу 1."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"),
                    Number = 6,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}5. Строим экспериментальную характеристику Uг = f(n)."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"),
                    Number = 8,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}6. Находим теоретическую скорость вращения тахогенератора nг, из расчёта 1В = 870 об/мин.\nnг = 870 * Uг\nВсе расчитанные данные заносим в таблицу 1.\n{Constants.Tab}7. Сравнивая показания скорости вращения тахогенератора nг и энкодера n можно заметить небольшие расхождения."
                },

                // -------------------------------------------
                // Lab 4
                // -------------------------------------------
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 0,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}1. Исследование резистивного датчика линейного перемещения\n{Constants.Tab}1.1. Подключаем мультиметр к гнёздам резистивного датчика (рис. 1).\nВыставляем предел измерения 200 кОм."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 2,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}1.2 Перемещая ползунок резистора вправо, регистрируем значения сопротивления R и перемещая X. Полученные данные заносим в таблицу 1."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 4,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}1.3 Строим статическую характеристику R = f(X)."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 6,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}2. Исследование оптоэлектрического датчика линейного перемещения.\n{Constants.Tab}2.1. Подключаем стенд к однофазной сети переменного тока 220В, 50Гц.\n{Constants.Tab}2.2. Вставляем кодовую линейку в отверстие.\n{Constants.Tab}2.3. Переводим автоматический выключатель «СЕТЬ» в верхнее положение.\n{Constants.Tab}2.4. Выставляем кодовую линейку на нулевое значение. При необходимости можно сбросить показания счетчика нажатием кнопки SB4.\n{Constants.Tab}2.5. Переводим тумблер SB3 в верхнее положение «Диодная оптопара».\n{Constants.Tab}2.6. Передвигаем кодовую линейку вправо, регистрируем количество «шагов» N и перемещение X. Полученные данные заносим в таблицу 2."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 8,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}2.7. Переводим тумблер SB3 в нижнее положение «Транзисторная оптопара».\n{Constants.Tab}2.8. Повторяем п. 4…6 для транзисторной оптопары и полученные данные заносим в таблицу 2.\n{Constants.Tab}2.9. Строим статическую характеристику N = f(X) для каждого типа оптопары."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 10,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}3. Исследование ёмкостного датчика линейного перемещения\n{Constants.Tab}3.1. Подключаем мультиметр к гнездам ёмкостного датчика линейного перемещения (рис. 2)."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 12,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}3.2 Передвигаем пластину датчика ручкой вправо, регистрируя значения емкости и перемещения. Полученные данные заносим в таблицу 3."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 14,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}3.3 Строим статическую характеристику Cx=f(X)."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 16,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}4. Исследование индуктивного датчика линейного перемещения\n{Constants.Tab}4.1. Подключаем мультиметр к гнездам индуктивного датчика линейного перемещения (рис. 3)."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 18,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}4.2. Передвигаем ферритовый сердечник влево, регистрируя значения индуктивности катушки и перемещения сердечника. Полученные данные заносим в таблицу 4."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 20,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}4.3. Строим статическую характеристику Lx=f(X)"
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 22,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}5. Исследование ультразвукового датчика линейного перемещения\n{Constants.Tab}5.1. Подключаем стенд к однофазной сети переменного тока 220В, 50Гц.\n{Constants.Tab}5.2. Переводим автоматический выключатель «СЕТЬ» в верхнее положение."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 24,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}5.3. Отодвинем подвижную пластину с экраном вправо от датчика, установив экран на торце подвижной пластины на метке «8» мерной шкалы. Индикатор d показывал расстояние до объекта.\n{Constants.Tab}5.4. Зафиксируем показания индикатора и сравним со значением мерной шкалы.\n{Constants.Tab}5.5. Повторим эксперимент, передвинув влево подвижную пластину с экраном влево на следующую метку мерной шкалы. Зафиксируем показания индикатора и сравним со значением мерной шкалы для каждого из положений подвижной пластины с экраном.\n{Constants.Tab}5.6. Полученные данные занесем в таблицу 5."
                },

                // -------------------------------------------
                // Lab 5
                // -------------------------------------------
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("202b2d34-b93e-45db-935b-3a1d050f36bb"),
                    Number = 0,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}1. Исследование бесконтактных датчиков-выключателей\n{Constants.Tab}1.1. Подключить стенд к однофазной сети переменного тока 220В, 50Гц.\n{Constants.Tab}1.2. Перевести автоматический выключатель «СЕТЬ» в верхнее положение."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("202b2d34-b93e-45db-935b-3a1d050f36bb"),
                    Number = 2,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}2. Исследование геркона\n{Constants.Tab}2.1. Медленно подносить магнит к геркону до момента срабатывания контрольного светодиода.\n{Constants.Tab}2.2. Оценить расстояние, на котором произошло срабатывание геркона.\n{Constants.Tab}Срабатывание геркона произошло на расстоянии 1.2 см от магнита.\n{Constants.Tab}2.3. Сделать выводы о минимальном расстоянии, на котором произошло срабатывание геркона.\n{Constants.Tab}Благодаря высокой чувствительности геркон можно успешно применять для различных датчиков положения и концевых выключателей. Из недостатков – хрупкая конструкция и намагничивание контактов со временем эксплуатации.\n{Constants.Tab}3. Исследование оптического датчика\n{Constants.Tab}3.1. Установить кодовую пластину в корпус оптического датчика.\n{Constants.Tab}3.2. Передвигать пластину влево/вправо и следить за работой контрольного светодиода.\n{Constants.Tab}Исходя из измерений, ширина окна оптического датчика составляет 1.6 см (2,4-0,8 см)\n{Constants.Tab}3.3. Сделать выводы о принципе работы оптического датчика-выключателя.\n{Constants.Tab}Оптический датчик состоит из источника (излучателя) и приемника оптического излучения, которые могут располагаться в одном или в разных корпусах Датчики такого типа используются для автоматизации любых промышленных процессов, в робототехнике, системах контроля, обработки и монтажа. Из достоинств такого вида датчика можно выделить высокую чувствительность и скорость срабатывания. Из недостатков: не работает в агрессивных средах и в средах с высокой степенью загрязнения.\n{Constants.Tab}4. Исследование индуктивного датчика\n{Constants.Tab}4.1. Медленно подвести металлическую пластину к индуктивному датчику, до момента срабатывания контрольного светодиода.\n{Constants.Tab}Расстояние от датчика, на котором сработал светодиод, составило 0,4 см.\n{Constants.Tab}4.2. Сделать выводы о минимальном расстоянии, на котором произошло срабатывание индуктивного датчика.\r\n\t\tПоскольку расстояние до срабатывания датчика оказалось существенно мало, по сравнению с герконом, можно сделать вывод о невысокой чувствительности такого датчика. И достоинств можно отметить очень простую конструкцию и возможность работать во всевозможных агрессивных средах."
                },

                // -------------------------------------------
                // Lab 6
                // -------------------------------------------
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"),
                    Number = 0,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}{Constants.Tab}A. Исследование потенциометра\n{Constants.Tab}1. Подключаем мультиметр к гнездам потенциометра (рисунок 1). Выставляем предел измерения 20кОм."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"),
                    Number = 2,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}2. Регулятором потенциометра изменяем угол поворота α и регистрируем показания сопротивления R. Полученные данные заносим в таблицу 1."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"),
                    Number = 4,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}3. Характеристика R=f(α)"
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"),
                    Number = 6,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}{Constants.Tab}B. Исследование цифрового датчика угла\n{Constants.Tab}1. Подключаем стенд к однофазной сети переменного тока 220В, 50Гц.\n{Constants.Tab}2. Переводим автоматический выключатель «СЕТЬ» в верхнее положение.\r\n"
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"),
                    Number = 8,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}3. Регулятором переключателя изменяем угол поворота α и регистрируем показания комбинаций светодиодов N. Полученные данные заносим в таблицу 2."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"),
                    Number = 10,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}4. Характеристика N=f(α)."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"),
                    Number = 12,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}{Constants.Tab}C. Исследование делителя напряжения\n{Constants.Tab}1. Подключаем стенд к однофазной сети переменного тока 220В, 50Гц.\n{Constants.Tab}2. Подключаем мультиметр к гнездам делителя напряжения (рисунок 5). Выставляем предел измерения 20В постоянного напряжения."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"),
                    Number = 14,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}3. Переводим автоматический выключатель «СЕТЬ» в верхнее положение.\n{Constants.Tab}4. Регулятором потенциометра изменяем угол поворота α и регистрируем показания напряжения U. Полученные данные заносим в таблицу 3."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"),
                    Number = 16,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}5. Характеристика U=f(α)"
                },

                // -------------------------------------------
                // Lab 7
                // -------------------------------------------
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("8133fde9-ab3a-4e8d-b819-4d543cdfa485"),
                    Number = 0,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}1. Подключаем стенд к однофазной сети переменного тока 220В, 50Гц.\n{Constants.Tab}2. Подключить мультиметр к гнездам датчика давления (рисунок 1). Выставить предел измерения 200мВ постоянного напряжения."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("8133fde9-ab3a-4e8d-b819-4d543cdfa485"),
                    Number = 3,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}3. Перевести автоматический выключатель «СЕТЬ» в верхнее положение.\n{Constants.Tab}4. Убедиться, что регулятор давления закрыт. Для этого вытянуть ручку на себя и повернуть влево до упора. Затем потянуть ручку регулятора давления от себя, убедиться, что ручка зафиксирована.\n{Constants.Tab}5. Перевести переключатель SB5 в верхнее положение («1») для включения воздушного компрессора. Когда давление воздуха в ресивере достигнет 0,6 МПа (контролировать по манометру), выключить воздушный компрессор переводом переключателя SB5 в нижнее положение («0»).\n{Constants.Tab}6. Вытянуть ручку регулятора давления на себя и поворотом ручки вправо плавно стравливать давление воздуха из ресивера. При этом регистрировать по манометру давление P, а по мультиметру напряжение U датчика давления. Полученные данные занести в таблицу 1."
                },
                new ParagraphElement
                {
                    Id = Guid.NewGuid(),
                    LabTemplateId = new Guid("8133fde9-ab3a-4e8d-b819-4d543cdfa485"),
                    Number = 5,
                    ElementType = ReportElementType.Paragraph,
                    Text = $"\n{Constants.Tab}7. Характеристика U=f(P)"
                },
            });
        }
    }
}

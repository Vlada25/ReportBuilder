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
            });
        }
    }
}

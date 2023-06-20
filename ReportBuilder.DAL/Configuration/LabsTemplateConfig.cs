﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReportBuilder.DAL.Common;
using ReportBuilder.DAL.Models;

namespace ReportBuilder.DAL.Configuration
{
    public class LabsTemplateConfig : IEntityTypeConfiguration<LabsTemplate>
    {
        public void Configure(EntityTypeBuilder<LabsTemplate> builder)
        {
            builder.HasData(new List<LabsTemplate>
            {
                new LabsTemplate
                {
                    Id = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                    Number = 1,
                    Theme = "Статические характеристики датчиков тока и напряжения",
                    Purpose = $"\n{Constants.Tab}1. Изучить принцип работы датчиков тока и напряжения\n" +
                        $"{Constants.Tab}2. Исследовать статические характеристики датчиков тока и напряжения",
                    Conclusion = "в ходе лабораторной работы изучил принцип работы датчиков тока и напряжения, а также на практике " +
                        "исследовал статические характеристики этих датчиков. По результатам  экспериментальных измерений было " +
                        "доказано, что зависимости измеряемых величин от входных значений имеют линейный характер, что облегчает съем " +
                        "измеряемых величин."
                },
                new LabsTemplate
                {
                    Id = new Guid("bd1b5bfe-0e1a-11ee-be56-0242ac120002"),
                    Number = 2 ,
                    Theme = "Тепловые преобразователи",
                    Purpose = $"Исследование характеристик термометров сопротивления, термисторов и термопар.",
                    Conclusion = "в ходе лабораторной работы изучил принцип работы термометров сопротивления, " +
                        "экспериментально снял и построил ВАХ терморезистора."
                },
                new LabsTemplate
                {
                    Id = new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"),
                    Number = 3,
                    Theme = "Статические характеристики тахогенератора и энкодера",
                    Purpose = " изучить принцип работы тахогенератора и энкодера. Исследовать характеристики тахогенератора и энкодера.",
                    Conclusion = "в ходе работы был изучен принцип работы тахогенератора (тахогенератор работает в генераторном режиме, и, снимая с его обмоток ЭДС, можно вычислить частоту вращения) и энкодера (энкодер состоит из оптического датчика и перфорированного диска; подсчитывая количество импульсов, можно определить угол поворота вращающегося вала). Также были исследованы их характеристики.",
                },
                new LabsTemplate
                {
                    Id = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                    Number = 4,
                    Theme = "Статические характеристики датчиков линейного перемещения",
                    Purpose = " изучить принцип работы датчиков линейного перемещения. Исследовать характеристики датчиков линейного перемещения.",
                    Conclusion = "в ходе работы были изучены принцип работы датчиков линейного перемещения, а также исследованы характеристики датчиков линейного перемещения."
                },
                new LabsTemplate
                {
                    Id = new Guid("202b2d34-b93e-45db-935b-3a1d050f36bb"),
                    Number = 5,
                    Theme = "Изучение принципа работы бесконтактных датчиков выключателей",
                    Purpose = " изучить устройство и принцип работы бесконтактных датчиков-выключателей.",
                    Conclusion = "в ходе работы были изучены на практике принцип работы бесконтактных датчиков-выключателей."
                },
                new LabsTemplate
                {
                    Id = new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"),
                    Number = 6,
                    Theme = "Статические характеристики датчиков углового положения",
                    Purpose = $"\n{Constants.Tab}1. Исследование потенциометра\n" +
                        $"{Constants.Tab}2. Изучить принцип работы датчиков углового положения\n" +
                        $"{Constants.Tab}3. Исследовать характеристики датчиков углового положения",
                    Conclusion = "в ходе лабораторной работы изучили принцип работы датчиков углового положения. Исследовали характеристики датчиков углового положения."
                },
                new LabsTemplate
                {
                    Id = new Guid("8133fde9-ab3a-4e8d-b819-4d543cdfa485"),
                    Number = 7,
                    Theme = "Статическая характеристика датчика давления",
                    Purpose = $"\n{Constants.Tab}1. Изучить устройство и принцип работы датчика давления.\n" +
                        $"{Constants.Tab}2. Исследовать статическую характеристику датчика давления\n",
                    Conclusion = "в ходе лабораторной работы изучили устройство и принцип работы датчика давления. Исследовали статическую характеристику датчика давления."
                },
            });
        }
    }
}

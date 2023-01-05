﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReportBuilder.DAL;

#nullable disable

namespace ReportBuilder.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230105112637_Test1")]
    partial class Test1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ReportBuilder.DAL.Models.LabsTemplate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Conclusion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Theme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LabsTemplates");

                    b.HasData(
                        new
                        {
                            Id = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                            Conclusion = "в ходе лабораторной работы изучил принцип работы датчиков тока и напряжения, а также на практике исследовал статические характеристики этих датчиков. По результатам  экспериментальных измерений было доказано, что зависимости измеряемых величин от входных значений имеют линейный характер, что облегчает съем измеряемых величин.",
                            Number = 1,
                            Purpose = "\n               1. Изучить принцип работы датчиков тока и напряжения\n               2. Исследовать статические характеристики датчиков тока и напряжения",
                            Theme = "Статические характеристики датчиков тока и напряжения"
                        },
                        new
                        {
                            Id = new Guid("3cfe4386-2c91-457e-a93b-ac90d7f4af4c"),
                            Conclusion = "в ходе работы был изучен принцип работы тахогенератора (тахогенератор работает в генераторном режиме, и, снимая с его обмоток ЭДС, можно вычислить частоту вращения) и энкодера (энкодер состоит из оптического датчика и перфорированного диска; подсчитывая количество импульсов, можно определить угол поворота вращающегося вала). Также были исследованы их характеристики.",
                            Number = 3,
                            Purpose = " изучить принцип работы тахогенератора и энкодера. Исследовать характеристики тахогенератора и энкодера.",
                            Theme = "Статические характеристики тахогенератора и энкодера"
                        },
                        new
                        {
                            Id = new Guid("5dc7ad45-59c5-4127-b209-97fc930bc3a2"),
                            Conclusion = "в ходе работы были изучены принцип работы датчиков линейного перемещения, а также исследованы характеристики датчиков линейного перемещения.",
                            Number = 4,
                            Purpose = " изучить принцип работы датчиков линейного перемещения. Исследовать характеристики датчиков линейного перемещения.",
                            Theme = "Статические характеристики датчиков линейного перемещения"
                        },
                        new
                        {
                            Id = new Guid("202b2d34-b93e-45db-935b-3a1d050f36bb"),
                            Conclusion = "в ходе работы были изучены на практике принцип работы бесконтактных датчиков-выключателей.",
                            Number = 5,
                            Purpose = " изучить устройство и принцип работы бесконтактных датчиков-выключателей.",
                            Theme = "Изучение принципа работы бесконтактных датчиков выключателей"
                        },
                        new
                        {
                            Id = new Guid("3c23fb4d-4efb-42e0-b9ba-86486e27f3fa"),
                            Conclusion = "в ходе лабораторной работы изучили принцип работы датчиков углового положения. Исследовали характеристики датчиков углового положения.",
                            Number = 6,
                            Purpose = "\n               1. Исследование потенциометра\n               2. Изучить принцип работы датчиков углового положения\n               3. Исследовать характеристики датчиков углового положения",
                            Theme = "Статические характеристики датчиков углового положения"
                        },
                        new
                        {
                            Id = new Guid("8133fde9-ab3a-4e8d-b819-4d543cdfa485"),
                            Conclusion = "в ходе лабораторной работы изучили устройство и принцип работы датчика давления. Исследовали статическую характеристику датчика давления.",
                            Number = 7,
                            Purpose = "\n               1. Изучить устройство и принцип работы датчика давления.\n               2. Исследовать статическую характеристику датчика давления\n",
                            Theme = "Статическая характеристика датчика давления"
                        });
                });

            modelBuilder.Entity("ReportBuilder.DAL.Models.ReportElement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ElementType")
                        .HasColumnType("int");

                    b.Property<Guid>("LabTemplateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ReportElements");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ReportElement");
                });

            modelBuilder.Entity("ReportBuilder.DAL.Models.ReportElements.ParagraphElement", b =>
                {
                    b.HasBaseType("ReportBuilder.DAL.Models.ReportElement");

                    b.HasDiscriminator().HasValue("ParagraphElement");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b3a36f8d-4a7b-4b8b-a197-20f9c58a5124"),
                            ElementType = 0,
                            LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                            Number = 0,
                            Text = "               1. Исследование шунта.\n               1.1. Собираем схему на рис.1 и снимаем значения Uш и Iн"
                        });
                });

            modelBuilder.Entity("ReportBuilder.DAL.Models.ReportElements.PictureElement", b =>
                {
                    b.HasBaseType("ReportBuilder.DAL.Models.ReportElement");

                    b.Property<int>("PictureNumber")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("PictureElement");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5abc4dfa-29dd-4c9c-8588-1f56d44254c5"),
                            ElementType = 1,
                            LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                            Number = 1,
                            Text = "Схема исследования шунта",
                            PictureNumber = 1
                        });
                });

            modelBuilder.Entity("ReportBuilder.DAL.Models.ReportElements.TableElement", b =>
                {
                    b.HasBaseType("ReportBuilder.DAL.Models.ReportElement");

                    b.Property<int>("ColumnsCount")
                        .HasColumnType("int");

                    b.Property<string>("HorizontalTitles")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RowsCount")
                        .HasColumnType("int");

                    b.Property<int>("TableNumber")
                        .HasColumnType("int");

                    b.Property<string>("VerticalTitles")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("TableElement");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2fd6351c-8dc7-4a9f-9208-7999ae8ba140"),
                            ElementType = 2,
                            LabTemplateId = new Guid("593a046b-d4f9-4110-a851-3e81a2871f7a"),
                            Number = 2,
                            Text = "Данные эксперимента",
                            ColumnsCount = 13,
                            RowsCount = 3,
                            TableNumber = 1,
                            VerticalTitles = "Uш, мВ;Iн, А;Iш, А"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

using ReportBuilder.DAL.Models;

namespace ReportBuilder.DAL
{
    public class CommonData
    {
        public static string GenerateTitleTopText(LabsTemplate template)
        {
            string text = "Министерство образования Республики Беларусь\n" +
                "Учреждение образования\n«Гомельский государственный технический университет\n" +
                "имени П.О. Сухого»\n\n\n\n\nКафедра «Промышленная электроника»\n\n\n\n\n" +
                $"Лабораторная работа №{template.Number}\n«{template.Theme}»\n" +
                $"по дисциплине «Электронные промышленные устройства»\n\n\n\n\n\n\n\n\n\n";
            return text;
        }

        public static string GenerateTitleRightText(PersonalData personalData)
        {
            string text = $"Выполнил:\nСтудент группы {personalData.StudentGroup}:\n" +
                $"{personalData.StudentFullName}\nПринял преподаватель:\n" +
                $"{personalData.TeacherFullName}\n\n\n\n\n\n";
            return text;
        }

        public static string GeneratePurposeText(LabsTemplate template)
        {
            string text = $"Цель работы:\n{template.Purpose}";

            return text;
        }
    }
}

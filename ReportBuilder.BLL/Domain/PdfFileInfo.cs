using ReportBuilder.BLL.DTO.LabsTemplate;
using ReportBuilder.DAL.Enums;
using ReportBuilder.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder.BLL.Domain
{
    public class PdfFileInfo
    {
        public string FilePath { get; set; }
        public string FontPath { get; set; }
        public LabsTemplateDto LabsTemplate { get; set; }
        public PersonalData PersonalData { get; set; }
        public List<ReportElement> ReportElements { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder.BLL.DTO.LabsTemplate
{
    public class LabsTemplateForUpdateDto
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string Theme { get; set; }
        public string Purpose { get; set; }
        public string Conclusion { get; set; }
    }
}

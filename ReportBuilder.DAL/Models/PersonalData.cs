using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder.DAL.Models
{
    public class PersonalData
    {
        public Guid Id { get; set; }
        public string TeacherFullName { get; set; }
        public string StudentFullName { get; set; }
        public string StudentGroup { get; set; }
    }
}

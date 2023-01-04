﻿using ReportBuilder.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder.BLL.DTO.PictureElement
{
    public class PictureElementForUpdateDto
    {
        public Guid LabTemplateId { get; set; }
        public int Number { get; set; }
        public ReportElementType ElementType { get; set; }
        public string Text { get; set; }
        public int PictureNumber { get; set; }
    }
}

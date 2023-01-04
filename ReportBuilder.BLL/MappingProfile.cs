using AutoMapper;
using ReportBuilder.BLL.DTO.LabsTemplate;
using ReportBuilder.BLL.DTO.ParagraphElement;
using ReportBuilder.BLL.DTO.PictureElement;
using ReportBuilder.BLL.DTO.TableElement;
using ReportBuilder.DAL.Models;
using ReportBuilder.DAL.Models.ReportElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder.BLL
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LabsTemplate, LabsTemplateDto>();
            CreateMap<LabsTemplateForCreationDto, LabsTemplate>();
            CreateMap<LabsTemplateForUpdateDto, LabsTemplate>();

            CreateMap<ParagraphElement, ParagraphElementDto>();
            CreateMap<ParagraphElementForCreationDto, ParagraphElement>();
            CreateMap<ParagraphElementForUpdateDto, ParagraphElement>();

            CreateMap<PictureElement, PictureElementDto>();
            CreateMap<PictureElementForCreationDto, PictureElement>();
            CreateMap<PictureElementForUpdateDto, PictureElement>();

            CreateMap<TableElement, TableElementDto>();
            CreateMap<TableElementForCreationDto, TableElement>();
            CreateMap<TableElementForUpdateDto, TableElement>();
        }
    }
}

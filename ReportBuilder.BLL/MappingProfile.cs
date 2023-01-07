using AutoMapper;
using ReportBuilder.BLL.Domain;
using ReportBuilder.BLL.DTO.LabsTemplate;
using ReportBuilder.BLL.DTO.ParagraphElement;
using ReportBuilder.BLL.DTO.PictureElement;
using ReportBuilder.BLL.DTO.TableElement;
using ReportBuilder.DAL.Models;
using ReportBuilder.DAL.Models.ReportElements;

namespace ReportBuilder.BLL
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LabsTemplate, LabsTemplateDto>().ReverseMap();
            CreateMap<LabsTemplateForCreationDto, LabsTemplate>();
            CreateMap<LabsTemplateForUpdateDto, LabsTemplate>();

            CreateMap<ParagraphElement, ParagraphElementDto>().ReverseMap();
            CreateMap<ParagraphElementForCreationDto, ParagraphElement>();
            CreateMap<ParagraphElementForUpdateDto, ParagraphElement>();

            CreateMap<PictureElement, PictureElementDto>().ReverseMap();
            CreateMap<PictureElementForCreationDto, PictureElement>().ReverseMap();
            CreateMap<PictureElementForUpdateDto, PictureElement>();

            CreateMap<TableElement, TableElementDto>().ReverseMap();
            CreateMap<TableElementForCreationDto, TableElement>();
            CreateMap<TableElementForUpdateDto, TableElement>();

            CreateMap<RegisterUser, User>();
        }
    }
}

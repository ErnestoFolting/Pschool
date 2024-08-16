using AutoMapper;
using PschoolBackend_DAL.Entities;

namespace PschoolBackend_BLL.DTOs.MappingProfiles
{
    public class ParentRedoProfile : Profile
    {
        public ParentRedoProfile()
        {
            CreateMap<ParentRedoDTO, Parent>();
            CreateMap<Parent, ParentRedoDTO>();
        }
    }
}

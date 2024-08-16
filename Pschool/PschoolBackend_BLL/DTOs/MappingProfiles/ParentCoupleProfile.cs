using AutoMapper;
using PschoolBackend_DAL.Entities;

namespace PschoolBackend_BLL.DTOs.MappingProfiles
{
    public class ParentCoupleProfile : Profile
    {
        public ParentCoupleProfile()
        {
            CreateMap<ParentCouple, ParentCoupleDTO>();
            CreateMap<ParentCoupleDTO, ParentCouple>();
        }
    }
}

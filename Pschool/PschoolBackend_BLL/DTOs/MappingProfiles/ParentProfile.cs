using AutoMapper;
using PschoolBackend_DAL.Entities;

namespace PschoolBackend_BLL.DTOs.MappingProfiles
{
    public class ParentProfile : Profile
    {
        public ParentProfile()
        {
            CreateMap<Parent, ParentDTO>()
                .ForMember(dest => dest.ParentCouple, opt => opt.MapFrom(src => src.ParentCoupleFromParent1 ?? src.ParentCoupleFromParent2));

            CreateMap<ParentDTO, Parent>();
        }
    }
}

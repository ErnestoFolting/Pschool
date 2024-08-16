using AutoMapper;
using PschoolBackend_DAL.Entities;

namespace PschoolBackend_BLL.DTOs.MappingProfiles
{
    public class ParentProfile : Profile
    {
        public ParentProfile()
        {
            CreateMap<StudentDTO, Student>();
        }
    }
}

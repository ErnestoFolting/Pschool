using AutoMapper;
using PschoolBackend_DAL.Entities;

namespace PschoolBackend_BLL.DTOs.MappingProfiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<StudentDTO, Student>();
        }
    }
}

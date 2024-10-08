﻿using AutoMapper;
using PschoolBackend_DAL.Entities;

namespace PschoolBackend_BLL.DTOs.MappingProfiles
{
    public class StudentRedoProfile : Profile
    {
        public StudentRedoProfile()
        {
            CreateMap<StudentRedoDTO, Student>();
            CreateMap<Student, StudentRedoDTO>();
        }
    }
}

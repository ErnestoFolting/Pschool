using AutoMapper;
using PschoolBackend_BLL.DTOs;
using PschoolBackend_BLL.Services.Interfaces;
using PschoolBackend_DAL.Entities;
using PschoolBackend_DAL.Interfaces;

namespace PschoolBackend_BLL.Services
{
    public class StudentService : BaseService, IStudentService
    {
        public StudentService(IUnitOfWork unitOfWork, IMapper mapper) 
        :base(unitOfWork, mapper)
        {
            
        }

        public async Task<List<StudentRedoDTO>> getStudents()
        {
            var students =_mapper.Map<List<StudentRedoDTO>> (await _unitOfWork.StudentRepository.GetAll());
            return students;
        }

        public async Task addStudent(StudentDTO studentToAdd)
        {
            await _unitOfWork.StudentRepository.Add(_mapper.Map<Student>(studentToAdd));
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task deleteStudent(int studentId)
        {
            var student = await _unitOfWork.StudentRepository.GetById(studentId);
            if (student == null) throw new KeyNotFoundException("Student not found.");
            await _unitOfWork.StudentRepository.DeleteById(student);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<int> updateStudent(StudentRedoDTO updateData, int studentId)
        {
            var studentInDb = await _unitOfWork.StudentRepository.GetById(studentId);
            if (studentInDb == null) throw new KeyNotFoundException("Student not found.");

            studentInDb = _mapper.Map(updateData, studentInDb);

            await _unitOfWork.StudentRepository.Update(studentInDb);
            return await _unitOfWork.SaveChangesAsync();
        }
    }
}

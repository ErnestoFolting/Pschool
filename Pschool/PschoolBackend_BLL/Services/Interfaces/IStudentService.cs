using PschoolBackend_BLL.DTOs;
using PschoolBackend_DAL.Entities;

namespace PschoolBackend_BLL.Services.Interfaces
{
    public interface IStudentService
    {
        Task addStudent(StudentDTO studentToAdd);
        Task deleteStudent(int studentId);
        public Task<List<Student>> getStudents();
        Task<int> updateStudent(StudentRedoDTO updateData);
    }
}

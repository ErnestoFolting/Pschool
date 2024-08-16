using PschoolBackend_BLL.DTOs;

namespace PschoolBackend_BLL.Services.Interfaces
{
    public interface IStudentService
    {
        Task addStudent(StudentDTO studentToAdd);
        Task deleteStudent(int studentId);
        public Task<List<StudentRedoDTO>> getStudents();
        Task<int> updateStudent(StudentRedoDTO updateData, int studentId);
    }
}

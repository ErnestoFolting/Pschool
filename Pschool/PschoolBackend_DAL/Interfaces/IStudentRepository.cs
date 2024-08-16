using PschoolBackend_DAL.Entities;

namespace PschoolBackend_DAL.Interfaces
{
    public interface IStudentRepository
    {
        Task Add(Student studentToAdd);
        Task DeleteById(Student studentToDelete);
        Task<List<Student>> GetAll();
        Task<Student?> GetById(int studentId);
        Task Update(Student studentInDb);
    }
}

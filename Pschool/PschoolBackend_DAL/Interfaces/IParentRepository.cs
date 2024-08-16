using PschoolBackend_DAL.Entities;

namespace PschoolBackend_DAL.Interfaces
{
    public interface IParentRepository
    {
        Task Add(Parent parentToAdd);
        Task DeleteById(Parent parentToDelete);
        Task<List<Parent>> GetAll();
        Task<Parent?> GetById(int parentId);
        Task Update(Parent parenttInDb);
    }
}

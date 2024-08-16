using PschoolBackend_DAL.Entities;

namespace PschoolBackend_DAL.Interfaces
{
    public interface IParentCoupleRepository
    {
        public Task<List<ParentCouple>> GetAll();
        public Task Add(ParentCouple parentCoupleToAdd);
        Task Delete(ParentCouple parentCouple);
        Task<ParentCouple> GetById(int parentCoupleId);
    }
}

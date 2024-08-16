using PschoolBackend_DAL.Entities;

namespace PschoolBackend_DAL.Interfaces
{
    public interface IParentCoupleRepository
    {
        public Task<List<ParentCouple>> GetAll();
    }
}

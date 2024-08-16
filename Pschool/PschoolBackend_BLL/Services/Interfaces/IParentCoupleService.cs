using PschoolBackend_BLL.DTOs;
using PschoolBackend_DAL.Entities;

namespace PschoolBackend_BLL.Services.Interfaces
{
    public interface IParentCoupleService
    {
        public Task<List<ParentCouple>> getParentCouples();
        public Task addParentCouple(ParentCoupleDTO parentCoupleToAdd);
    }
}

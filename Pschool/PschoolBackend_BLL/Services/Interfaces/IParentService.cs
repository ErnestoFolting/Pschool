using PschoolBackend_BLL.DTOs;
using PschoolBackend_DAL.Entities;

namespace PschoolBackend_BLL.Services.Interfaces
{
    public interface IParentService
    {
        Task addParent(ParentDTO parentToAdd);
        Task deleteParent(int parentId);
        public Task<List<ParentDTO>> getParents();
        Task<int> updateParent(ParentRedoDTO updateData, int parentId);
    }
}

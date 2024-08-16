using AutoMapper;
using PschoolBackend_BLL.DTOs;
using PschoolBackend_BLL.Services.Interfaces;
using PschoolBackend_DAL.Entities;
using PschoolBackend_DAL.Interfaces;

namespace PschoolBackend_BLL.Services
{
    public class ParentService : BaseService, IParentService
    {
        public ParentService(IUnitOfWork unitOfWork, IMapper mapper)
        : base(unitOfWork, mapper)
        {

        }
        public async Task addParent(ParentDTO parentToAdd)
        {
            await _unitOfWork.ParentRepository.Add(_mapper.Map<Parent>(parentToAdd));
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task deleteParent(int parentId)
        {
            var student = await _unitOfWork.ParentRepository.GetById(parentId);
            if (student == null) throw new KeyNotFoundException("Parent not found.");
            await _unitOfWork.ParentRepository.DeleteById(student);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<Parent>> getParents()
        {
            var parents = await _unitOfWork.ParentRepository.GetAll();
            return parents;
        }

        public async Task<int> updateParent(ParentRedoDTO updateData)
        {
            var parentInDb = await _unitOfWork.ParentRepository.GetById(updateData.Id);
            if (parentInDb == null) throw new KeyNotFoundException("Parent not found.");

            parentInDb = _mapper.Map(updateData, parentInDb);

            await _unitOfWork.ParentRepository.Update(parentInDb);
            return await _unitOfWork.SaveChangesAsync();
        }
    }
}

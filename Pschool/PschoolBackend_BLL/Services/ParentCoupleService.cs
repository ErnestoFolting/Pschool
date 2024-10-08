﻿using AutoMapper;
using PschoolBackend_BLL.DTOs;
using PschoolBackend_BLL.Services.Interfaces;
using PschoolBackend_DAL.Entities;
using PschoolBackend_DAL.Interfaces;

namespace PschoolBackend_BLL.Services
{
    public class ParentCoupleService : BaseService, IParentCoupleService
    {
        public ParentCoupleService(IUnitOfWork uof, IMapper am)
            :base(uof,am)
        {
            
        }
        public async Task<List<ParentCouple>> getParentCouples()
        {
            var parentCouples = await _unitOfWork.ParentCoupleRepository.GetAll();
            return parentCouples;
        }
        public async Task addParentCouple(ParentCoupleDTO parentCoupleToAdd)
        {
            await _unitOfWork.ParentCoupleRepository.Add(_mapper.Map<ParentCouple>(parentCoupleToAdd));
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task deleteParentCouple(int parentCoupleId)
        {
            var parentCouple = await _unitOfWork.ParentCoupleRepository.GetById(parentCoupleId);
            if (parentCouple == null) throw new KeyNotFoundException("Parent couple not found.");
            await _unitOfWork.ParentCoupleRepository.Delete(parentCouple);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}

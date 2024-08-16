using AutoMapper;
using PschoolBackend_DAL.Interfaces;

namespace PschoolBackend_BLL.Services.Interfaces
{
    public class BaseService
    {
        private protected readonly IUnitOfWork _unitOfWork;
        private protected readonly IMapper _mapper;

        public BaseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
    }
}

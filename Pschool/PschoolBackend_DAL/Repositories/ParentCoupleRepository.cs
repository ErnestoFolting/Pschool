using PschoolBackend_DAL.Interfaces;

namespace PschoolBackend_DAL.Repositories
{
    internal class ParentCoupleRepository : IParentCoupleRepository
    {
        private readonly DataContext _context;
        public ParentCoupleRepository(DataContext context)
        {
            _context = context;
        }
    }
}

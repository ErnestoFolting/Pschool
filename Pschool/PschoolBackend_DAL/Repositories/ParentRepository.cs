using PschoolBackend_DAL.Interfaces;

namespace PschoolBackend_DAL.Repositories
{
    internal class ParentRepository : IParentRepository
    {
        private readonly DataContext _context;
        public ParentRepository(DataContext context)
        {
            _context = context;
        }
    }
}

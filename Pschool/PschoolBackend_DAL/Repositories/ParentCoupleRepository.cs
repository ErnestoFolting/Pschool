using Microsoft.EntityFrameworkCore;
using PschoolBackend_DAL.Entities;
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
        public async Task<List<ParentCouple>> GetAll()
        {
            return await _context.Set<ParentCouple>().ToListAsync();
        }
    }
}

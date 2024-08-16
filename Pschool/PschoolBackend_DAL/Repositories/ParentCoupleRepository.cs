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
        public async Task Add(ParentCouple parentCoupleToAdd)
        {
            await _context.Set<ParentCouple>().AddAsync(parentCoupleToAdd);
        }

        public async Task Delete(ParentCouple parentCoupleToDelete)
        {
            _context.Set<ParentCouple>().Remove(parentCoupleToDelete);
        }

        public async Task<ParentCouple?> GetById(int parentCoupleId)
        {
            return await _context.Set<ParentCouple>().FirstOrDefaultAsync(el => el.Id == parentCoupleId);
        }
    }
}

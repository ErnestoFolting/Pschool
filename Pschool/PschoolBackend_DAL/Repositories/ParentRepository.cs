using Microsoft.EntityFrameworkCore;
using PschoolBackend_DAL.Entities;
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
        public async Task<List<Parent>> GetAll()
        {
            return await _context.Set<Parent>().Include(p=>p.ParentCoupleFromParent1).Include(p=>p.ParentCoupleFromParent2).ToListAsync();
        }

        public async Task Add(Parent parentToAdd)
        {
            await _context.Set<Parent>().AddAsync(parentToAdd);
        }

        public async Task DeleteById(Parent parentToDelete)
        {
            _context.Set<Parent>().Remove(parentToDelete);
        }

        public async Task<Parent?> GetById(int parentId)
        {
            return await _context.Set<Parent>().FirstOrDefaultAsync(el => el.Id == parentId);
        }

        public async Task Update(Parent parentInDb)
        {
            _context.Set<Parent>().Attach(parentInDb);
            _context.Entry(parentInDb).State = EntityState.Modified;
        }
    }
}

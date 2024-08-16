using Microsoft.EntityFrameworkCore;
using PschoolBackend_DAL.Entities;
using PschoolBackend_DAL.Interfaces;

namespace PschoolBackend_DAL.Repositories
{
    internal class StudentRepository : IStudentRepository
    {
        private readonly DataContext _context;
        public StudentRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> GetAll()
        {
            return await _context.Set<Student>().Include(s=>s.ParentCouple).ToListAsync();
        }

        public async Task Add(Student studentToAdd)
        {
            await _context.Set<Student>().AddAsync(studentToAdd);
        }

        public async Task DeleteById(Student studentToDelete)
        {
            _context.Set<Student>().Remove(studentToDelete);
        }

        public async Task<Student?> GetById(int studentId)
        {
            return await _context.Set<Student>().FirstOrDefaultAsync(el => el.Id == studentId);
        }

        public async Task Update(Student studentInDb)
        {
            _context.Set<Student>().Attach(studentInDb);
            _context.Entry(studentInDb).State = EntityState.Modified;
        }
    }
}

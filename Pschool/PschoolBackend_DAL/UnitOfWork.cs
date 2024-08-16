using PschoolBackend_DAL.Interfaces;
using PschoolBackend_DAL.Repositories;

namespace PschoolBackend_DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public IParentRepository ParentRepository { get; }

        public IStudentRepository StudentRepository { get; }

        public IParentCoupleRepository ParentCoupleRepository { get; }

        public UnitOfWork(DataContext context)
        {
            _context = context;
            ParentRepository = new ParentRepository(context);
            StudentRepository = new StudentRepository(context);
            ParentCoupleRepository = new ParentCoupleRepository(context);
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}

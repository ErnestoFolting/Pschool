namespace PschoolBackend_DAL.Interfaces
{
    public interface IUnitOfWork
    {
        public IParentRepository ParentRepository{ get; }
        public IStudentRepository StudentRepository { get; }
        public IParentCoupleRepository ParentCoupleRepository { get; }
        Task<int> SaveChangesAsync();
    }
}

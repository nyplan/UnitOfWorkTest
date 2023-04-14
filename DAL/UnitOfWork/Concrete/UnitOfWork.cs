using UnitOfWork.DAL.Abstract;
using UnitOfWork.DAL.Contexts;
using UnitOfWork.DAL.UnitOfWork.Abstract;

namespace UnitOfWork.DAL.UnitOfWork.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        public IUserRepository UserRepository { get; set; }
        public IRoleRepository RoleRepository { get; set; }
        private readonly MyContext _context;
        public UnitOfWork(IUserRepository userRepository, IRoleRepository roleRepository, MyContext context)
        {
            UserRepository = userRepository;
            RoleRepository = roleRepository;
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}

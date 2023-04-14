using UnitOfWork.DAL.Abstract;
using UnitOfWork.DAL.Contexts;
using UnitOfWork.Entities;

namespace UnitOfWork.DAL.Concrete
{
    public class RoleRepository : IRoleRepository
    {
        private readonly MyContext _context;

        public RoleRepository(MyContext context)
        {
            _context = context;
        }

        public void Add(Role role)
        {
            _context.Roles.Add(role);
        }
        public void Delete(Role role)
        {
            _context.Roles.Remove(role);
        }

        public IEnumerable<Role> GetAll()
        {
            return _context.Roles;
        }

        public Role GetById(int id)
        {
            return _context.Roles.Find(id);
        }

        public void Update(Role role)
        {
            _context.Roles.Update(role);
        }
    }
}

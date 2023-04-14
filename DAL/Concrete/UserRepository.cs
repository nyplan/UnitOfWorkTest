using Microsoft.EntityFrameworkCore;
using UnitOfWork.DAL.Abstract;
using UnitOfWork.DAL.Contexts;
using UnitOfWork.Entities;

namespace UnitOfWork.DAL.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly MyContext _context;

        public UserRepository(MyContext context)
        {
            _context = context;
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
        }

        public void Delete(User user)
        {
            _context.Users.Remove(user);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.Include(c => c.Role);
        }

        public User GetById(int id)
        {
            return _context.Users.Find(id);
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
        }
    }
}

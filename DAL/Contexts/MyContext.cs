using Microsoft.EntityFrameworkCore;
using UnitOfWork.Entities;

namespace UnitOfWork.DAL.Contexts
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}

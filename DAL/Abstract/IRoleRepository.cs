using UnitOfWork.Entities;

namespace UnitOfWork.DAL.Abstract
{
    public interface IRoleRepository
    {
        IEnumerable<Role> GetAll();
        Role GetById(int id);
        void Add(Role role);
        void Update(Role role);
        void Delete(Role role);
    }
}

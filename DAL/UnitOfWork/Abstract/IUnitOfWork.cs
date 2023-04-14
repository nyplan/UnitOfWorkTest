using UnitOfWork.DAL.Abstract;

namespace UnitOfWork.DAL.UnitOfWork.Abstract
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IRoleRepository RoleRepository { get; }
        void Commit();
    }
}

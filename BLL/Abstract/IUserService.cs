using UnitOfWork.DTOs.UserDTOs;

namespace UnitOfWork.BLL.Abstract
{
    public interface IUserService
    {
        IEnumerable<UserToListDto> GetAll();
        UserByIdDto GetById(int id);
        void Add(UserToAddDto dto);
        void Update(UserToUpdateDto dto);
        void Delete(int id);
    }
}

using AutoMapper;
using UnitOfWork.BLL.Abstract;
using UnitOfWork.DAL.Abstract;
using UnitOfWork.DAL.UnitOfWork.Abstract;
using UnitOfWork.DTOs.UserDTOs;
using UnitOfWork.Entities;

namespace UnitOfWork.BLL.Concrete
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public void Add(UserToAddDto dto)
        {
            User entity = _mapper.Map<User>(dto);
            _unitOfWork.UserRepository.Add(entity);
            _unitOfWork.RoleRepository.Add(new Role()
            {
                Id = 1,
                Name = "Role 1",
                Key = "Key 1"
            });
            _unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            User entity = _unitOfWork.UserRepository.GetById(id);
            _unitOfWork.UserRepository.Delete(entity);
        }

        public IEnumerable<UserToListDto> GetAll()
        {
            IEnumerable<User> entities = _unitOfWork.UserRepository.GetAll();
            return _mapper.Map<IEnumerable<UserToListDto>>(entities);
        }

        public UserByIdDto GetById(int id)
        {
            User entity = _unitOfWork.UserRepository.GetById(id);
            return _mapper.Map<UserByIdDto>(entity);
        }

        public void Update(UserToUpdateDto dto)
        {
            _unitOfWork.UserRepository.Update(_mapper.Map<User>(dto));
        }
    }
}

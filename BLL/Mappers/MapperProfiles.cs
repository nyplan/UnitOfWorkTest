using AutoMapper;
using UnitOfWork.DTOs.UserDTOs;
using UnitOfWork.Entities;

namespace UnitOfWork.BLL.Mappers
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<User, UserToListDto>()
                .ForMember(dest => dest.Role, src => src.MapFrom(c => c.Role.Name));
            CreateMap<User, UserByIdDto>()
                .ForMember(dest => dest.Role, src => src.MapFrom(c => c.Role.Name));
            CreateMap<UserToAddDto, User>();
            CreateMap<UserToUpdateDto, User>();
        }
    }
}

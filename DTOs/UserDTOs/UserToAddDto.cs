using UnitOfWork.Entities;

namespace UnitOfWork.DTOs.UserDTOs
{
    public record UserToAddDto
    {
        public string Name { get; set; }
        public int RoleId { get; set; }
    }
}

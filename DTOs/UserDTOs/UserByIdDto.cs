using UnitOfWork.Entities;

namespace UnitOfWork.DTOs.UserDTOs
{
    public record UserByIdDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }
}

namespace UnitOfWork.DTOs.UserDTOs
{
    public record UserToUpdateDto
    {
        public string Name { get; set; }
        public int RoleId { get; set; }
    }
}

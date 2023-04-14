namespace UnitOfWork.DTOs.UserDTOs
{
    public record UserToListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }
}

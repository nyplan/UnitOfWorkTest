﻿namespace UnitOfWork.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public bool IsDeleted { get; set; }
    }
}

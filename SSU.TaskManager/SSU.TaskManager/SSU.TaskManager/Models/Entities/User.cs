﻿namespace SSU.TaskManager.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}

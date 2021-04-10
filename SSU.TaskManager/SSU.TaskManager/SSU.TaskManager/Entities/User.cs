using SSU.TaskManager.Entities;

namespace SSU.TaskManager.Models.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}

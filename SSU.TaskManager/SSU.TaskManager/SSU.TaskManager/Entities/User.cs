using SSU.TaskManager.Entities;
using System.Collections.Generic;

namespace SSU.TaskManager.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            Tasks = new List<Task>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }
}

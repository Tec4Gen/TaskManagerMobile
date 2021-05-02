using SSU.TaskManager.Entities;
using System.Collections.Generic;

namespace SSU.TaskManager.Entities
{
    public class Group : BaseEntity
    {
        public Group()
        {
            Users = new List<User>();
            Tasks = new List<Task>();
        }
        public string Title { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}

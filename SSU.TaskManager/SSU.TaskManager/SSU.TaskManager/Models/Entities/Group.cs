using System.Collections.Generic;

namespace SSU.TaskManager.Models.Entities
{
    public class Group
    {
        public Group()
        {
            Users = new List<User>();
            Tasks = new List<Task>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}

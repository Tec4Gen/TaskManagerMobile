using System.Collections.Generic;

namespace SSU.TaskManager.Models.Entities
{
    public class Role
    {
        public Role()
        {
            Users = new List<User>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<User>  Users { get; set; }
    }
}

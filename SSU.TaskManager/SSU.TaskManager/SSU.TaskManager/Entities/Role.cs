using SSU.TaskManager.Entities;
using System.Collections.Generic;

namespace SSU.TaskManager.Models.Entities
{
    public class Role : BaseEntity
    {
        public Role()
        {
            Users = new List<User>();
        }
        public string Title { get; set; }
        public ICollection<User>  Users { get; set; }
    }
}

using SSU.TaskManager.Entities;
using System.Collections.Generic;

namespace SSU.TaskManager.Entities
{
    public class Board : BaseEntity
    {
        public Board()
        {
            Tasks = new List<Task>();
        }

        public string Title { get; set; }

        public ICollection<Task> Tasks{ get; set; }
    }
}

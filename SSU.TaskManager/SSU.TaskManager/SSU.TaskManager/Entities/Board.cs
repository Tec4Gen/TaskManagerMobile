using System.Collections.Generic;

namespace SSU.TaskManager.Models.Entities
{
    public class Board
    {
        public Board()
        {
            Tasks = new List<Task>();
        }
        public int Id { get; set; }

        public string Title { get; set; }

        public ICollection<Task> Tasks{ get; set; }
    }
}

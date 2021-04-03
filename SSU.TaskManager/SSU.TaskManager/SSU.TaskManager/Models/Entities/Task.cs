using System;

namespace SSU.TaskManager.Models.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public int BoardId { get; set; }
        public Board Board { get; set; }

    }
}

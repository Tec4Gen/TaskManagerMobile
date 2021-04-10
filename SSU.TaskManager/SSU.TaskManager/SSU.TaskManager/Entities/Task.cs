using SSU.TaskManager.Entities;
using System;

namespace SSU.TaskManager.Models.Entities
{
    public class Task : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string DeadLine { get; set; }
        public int? GroupId { get; set; }
        public Group Group { get; set; }
        public int? BoardId { get; set; }
        public Board Board { get; set; }

    }
}

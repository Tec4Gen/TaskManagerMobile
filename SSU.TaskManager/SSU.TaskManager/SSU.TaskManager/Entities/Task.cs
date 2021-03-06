using SSU.TaskManager.Entities;
using System;

namespace SSU.TaskManager.Entities
{
    public class Task : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string DeadLine { get; set; }
        public int? BoardId { get; set; }
        public Board Board { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
    }
}

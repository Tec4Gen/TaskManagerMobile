﻿using Microsoft.EntityFrameworkCore;
using SSU.TaskManager.Models.DaoInterface;
using SSU.TaskManager.Entities;

namespace SSU.TaskManager.Models.Repository
{
    public class TaskRepository: Repository<Task>, ITaskRepository
    {
        public TaskRepository(DbContext dbContext): base (dbContext) {}
    }
}

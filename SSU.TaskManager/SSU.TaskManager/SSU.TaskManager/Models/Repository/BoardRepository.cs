﻿using Microsoft.EntityFrameworkCore;
using SSU.TaskManager.Models.DaoInterface;
using SSU.TaskManager.Models.Entities;

namespace SSU.TaskManager.Models.Repository
{
    public class BoardRepository : Repository<Board>, IBoardRepository 
    {
        public BoardRepository(DbContext dbContext): base(dbContext) {}
    }

}

using Microsoft.EntityFrameworkCore;
using SSU.TaskManager.Models.DaoInterface;
using SSU.TaskManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SSU.TaskManager.Models.Repository
{
    public class RoleRepository: IRoleRepository
    {
        protected readonly DbContext _dbContext;

        public RoleRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Role> GetAll()
        {
            return _dbContext.Set<Role>();
        }

        public IEnumerable<Role> GetByCondition(Expression<Func<Role, bool>> where)
        {
            return _dbContext.Set<Role>().Where(where);
        }

        public Role GetById(int id)
        {
            return _dbContext.Set<Role>().Find(id);
        }
    }
}

using SSU.TaskManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SSU.TaskManager.Models.DaoInterface
{
    public interface IRoleRepository
    {
        IEnumerable<Role> GetAll();
        Role GetById(int id);
        IEnumerable<Role> GetByCondition(Expression<Func<Role, bool>> where);
    }
}

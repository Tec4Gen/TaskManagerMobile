using SSU.TaskManager.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SSU.TaskManager.BusinessLogic.ServiceInterface
{
    public interface IRoleService
    {
        IEnumerable<Role> GetAll();
        Role GetById(int id);
        IEnumerable<Role> GetByCondition(Expression<Func<Role, bool>> where);
    }
}

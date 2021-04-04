using SSU.TaskManager.BusinessLogic.ServiceInterface;
using SSU.TaskManager.Models.DaoInterface;
using SSU.TaskManager.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SSU.TaskManager.BusinessLogic.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public IEnumerable<Role> GetAll()
        {
            return _roleRepository.GetAll();
        }

        public IEnumerable<Role> GetByCondition(Expression<Func<Role, bool>> where)
        {
            return _roleRepository.GetByCondition(where);
        }

        public Role GetById(int id)
        {
            return _roleRepository.GetById(id);
        }
    }
}

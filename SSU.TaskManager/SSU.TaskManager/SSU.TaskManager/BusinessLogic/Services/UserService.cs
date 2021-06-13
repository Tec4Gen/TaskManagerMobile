using SSU.TaskManager.BusinessLogic.ServiceInterface;
using SSU.TaskManager.Models.DaoInterface;
using SSU.TaskManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace SSU.TaskManager.BusinessLogic.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userService;

        public UserService(IUserRepository userService)
        {
            _userService = userService;
        }

        public void Add(User entity)
        {
            _userService.Add(entity);
        }

        public void Delete(int id)
        {
            _userService.Delete(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _userService.GetAll();
        }

        public IEnumerable<User> GetByCondition(Func<User, bool> where)
        {
            return _userService.GetAll().Where(where);
        }

        public User GetById(int id)
        {
            return _userService.GetById(id);
        }

        public void Update(User entity)
        {
            _userService.Update(entity);
        }
    }
}

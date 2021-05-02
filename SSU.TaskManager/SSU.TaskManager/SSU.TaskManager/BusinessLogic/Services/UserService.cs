using SSU.TaskManager.BusinessLogic.ServiceInterface;
using SSU.TaskManager.Models.DaoInterface;
using SSU.TaskManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

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

        public void Delete(User entity)
        {
            _userService.Delete(entity);
        }

        public IEnumerable<User> GetAll()
        {
            return _userService.GetAll();
        }

        public IEnumerable<User> GetByCondition(Expression<Func<User, bool>> where)
        {
            return _userService.GetByCondition(where);
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

using SSU.TaskManager.BusinessLogic.ServiceInterface;
using SSU.TaskManager.Models.DaoInterface;
using SSU.TaskManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace SSU.TaskManager.BusinessLogic.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public void Add(Task entity)
        {
            _taskRepository.Add(entity);
        }

        public void Delete(int id)
        {
            _taskRepository.Delete(id);
        }

        public IEnumerable<Task> GetAll()
        {
            return _taskRepository.GetAll();
        }

        public IEnumerable<Task> GetByCondition(Func<Task, bool> where)
        {
            return _taskRepository.GetAll().Where(where);
        }

        public Task GetById(int id)
        {
            return _taskRepository.GetById(id);
        }

        public void Update(Task entity)
        {
            _taskRepository.Update(entity);
        }
    }
}

using SSU.TaskManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SSU.TaskManager
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SSU.TaskManager.Services.ServiceInterface
{
    public interface IService<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);
        IEnumerable<T> GetByCondition(Expression<Func<T, bool>> where);
    }
}

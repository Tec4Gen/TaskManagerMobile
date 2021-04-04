using SSU.TaskManager.Models.DaoInterface;
using SSU.TaskManager.Models.Entities;
using SSU.TaskManager.Services.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


namespace SSU.TaskManager.Services.Services
{
    public class GroupService : IGroupService
    {
        private readonly IGroupRepository _groupRepository;

        public GroupService(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        public void Add(Group entity)
        {
            _groupRepository.Add(entity);
        }

        public void Delete(Group entity)
        {
            _groupRepository.Delete(entity);
        }

        public IEnumerable<Group> GetAll()
        {
            return _groupRepository.GetAll();
        }

        public IEnumerable<Group> GetByCondition(Expression<Func<Group, bool>> where)
        {
            return _groupRepository.GetByCondition(where);
        }

        public Group GetById(int id)
        {
            return _groupRepository.GetById(id);
        }

        public void Update(Group entity)
        {
            _groupRepository.Update(entity);
        }
    }
}

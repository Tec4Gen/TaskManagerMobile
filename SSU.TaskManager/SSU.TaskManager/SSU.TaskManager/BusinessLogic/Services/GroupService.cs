using SSU.TaskManager.BusinessLogic.ServiceInterface;
using SSU.TaskManager.Models.DaoInterface;
using SSU.TaskManager.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace SSU.TaskManager.BusinessLogic.Services
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

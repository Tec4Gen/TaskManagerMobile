using Microsoft.EntityFrameworkCore;
using SSU.TaskManager.Models.DaoInterface;
using SSU.TaskManager.Models.Entities;

namespace SSU.TaskManager.Models.Repository
{
    public class GroupRepository: Repository<Group>, IGroupRepository
    {
        public GroupRepository(DbContext dbContext): base(dbContext)
        {

        }
    }
}

using Microsoft.EntityFrameworkCore;
using SSU.TaskManager.Models.DaoInterface;
using SSU.TaskManager.Models.Entities;

namespace SSU.TaskManager.Models.Repository
{
    public class RoleRepository: Repository<Role>, IRoleRepository
    {
        public RoleRepository(DbContext dbContext) : base (dbContext) {}
    }
}

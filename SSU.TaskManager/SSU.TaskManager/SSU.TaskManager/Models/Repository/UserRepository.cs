using Microsoft.EntityFrameworkCore;
using SSU.TaskManager.Models.DaoInterface;
using SSU.TaskManager.Models.Entities;

namespace SSU.TaskManager.Models.Repository
{
    public class UserRepository: Repository<User>, IUserRepository
    {
        public UserRepository(DbContext dbContext): base(dbContext) {}
    }
}

using Microsoft.EntityFrameworkCore;
using SSU.TaskManager.Models.Entities;

namespace SSU.TaskManager.Models.Dao
{
    public class TaskManagerContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Group> Groups { get; set; }

        public TaskManagerContext(DbContextOptions<TaskManagerContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.
                ApplyConfiguration(new GroupConfiguration());
            modelBuilder.
                ApplyConfiguration(new RoleConfiguration());
            modelBuilder.
                ApplyConfiguration(new TaskConfiguration());
            modelBuilder.
                ApplyConfiguration(new UserConfiguration());
            modelBuilder.
                ApplyConfiguration(new BoardConfiguration());
        }
    }
}

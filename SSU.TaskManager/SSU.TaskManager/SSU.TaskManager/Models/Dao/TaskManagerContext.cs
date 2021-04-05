using Microsoft.EntityFrameworkCore;
using SSU.TaskManager.Models.Entities;
using System;
using System.IO;
using Xamarin.Forms;

namespace SSU.TaskManager.Models.Dao
{
    public class TaskManagerContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=.\..\..\SSU.TaskManager\SSU.TaskManager\SSU.TaskManager\database.db");
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

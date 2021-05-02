using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SSU.TaskManager.BusinessLogic.ServiceInterface;
using SSU.TaskManager.BusinessLogic.Services;
using SSU.TaskManager.Models.Dao;
using SSU.TaskManager.Models.DaoInterface;
using SSU.TaskManager.Models.Repository;
using System;
using System.IO;

namespace SSU.TaskManager.Common.Ioc
{
    public static class DependenciesResolver
    {
        public static IServiceProvider Kernel { get; private set; }
        private static IServiceCollection _services { get; set; }

        static DependenciesResolver()
        {
            _services = new ServiceCollection();
            Kernel = Configurates();
        }

        private static IServiceProvider Configurates() 
        {
            _services.AddDbContext<TaskManagerContext>(options =>
               options.UseSqlite(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "database.db"),
               x => x.MigrationsAssembly("SSU.TaskManager"))); //TODO: change it)

            _services.AddTransient<ITaskRepository, TaskRepository>();
            _services.AddTransient<IBoardRepository, BoardRepository>();
            _services.AddTransient<IRoleRepository, RoleRepository>();
            _services.AddTransient<IUserRepository, UserRepository>();
            _services.AddTransient<IGroupRepository, GroupRepository>();


            _services.AddTransient<ITaskService, TaskService>();
            _services.AddTransient<IBoardService, BoardService>();
            _services.AddTransient<IRoleService, RoleService>();
            _services.AddTransient<IUserService, UserService>();
            _services.AddTransient<IGroupService, GroupService>();

            return _services.BuildServiceProvider();
        }
    }
}

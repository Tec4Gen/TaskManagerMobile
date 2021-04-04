using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SSU.TaskManager.BusinessLogic.ServiceInterface;
using SSU.TaskManager.BusinessLogic.Services;
using SSU.TaskManager.Models.Dao;
using SSU.TaskManager.Models.DaoInterface;
using SSU.TaskManager.Models.Repository;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SSU.TaskManager.Common.Ioc
{
    public static class DependenciesResolver
    {
        public static IServiceCollection Kernel { get;private set; }

        static DependenciesResolver()
        {
            Kernel = new ServiceCollection();
            Configurates();
        }

        private static void Configurates() 
        {
            Kernel.AddDbContext<TaskManagerContext>(options =>
               options.UseSqlite(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "database.db"),
               x => x.MigrationsAssembly("SSU.TaskManager")));

            Kernel.AddTransient<ITaskRepository, TaskRepository>();
            Kernel.AddTransient<IBoardRepository, BoardRepository>();
            Kernel.AddTransient<IRoleRepository, RoleRepository>();
            Kernel.AddTransient<IUserRepository, UserRepository>();
            Kernel.AddTransient<IGroupRepository, GroupRepository>();


            Kernel.AddTransient<ITaskService, TaskService>();
            Kernel.AddTransient<IBoardService, BoardService>();
            Kernel.AddTransient<IRoleService, RoleService>();
            Kernel.AddTransient<IUserService, UserService>();
            Kernel.AddTransient<IGroupService, GroupService>();
        }
    }
}

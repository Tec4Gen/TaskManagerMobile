using SSU.TaskManager.BusinessLogic.ServiceInterface;
using SSU.TaskManager.Common.Ioc;
using System.Collections.Generic;

namespace SSU.TaskManager.ViewModels
{
    public class ToDoListViewModel
    {
        public static List<string> Names { get; set; } = new List<string> { "Поесть", "Покодить", "Поспать" };

       
        private ToDoListViewModel()
        {
        }

        public string Name { private set; get; }

        private static string[] toDoitems = new string[] { "Поесть", "Покодить", "Поспать" };

        public static List<ToDoListViewModel> All { private set; get; }

        // Static members.
        static ToDoListViewModel()
        {
            
            List<ToDoListViewModel> all = new List<ToDoListViewModel>();

            // Loop through the public static fields of the Color structure.
            foreach (var name in toDoitems)
            {
                // Convert the name to a friendly name.

                var toDoItem = new ToDoListViewModel
                {
                    Name = name,
                };

                // Add it to the collection.
                all.Add(toDoItem);
            }
            All = all;
        }
    }
}


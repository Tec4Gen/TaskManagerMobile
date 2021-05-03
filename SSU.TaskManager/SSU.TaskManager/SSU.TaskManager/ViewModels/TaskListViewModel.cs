using SSU.TaskManager.BusinessLogic.ServiceInterface;
using SSU.TaskManager.Common.Ioc;
using SSU.TaskManager.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SSU.TaskManager.ViewModels
{
    public class TaskListViewModel
    {
        public static List<Task> ToDoList { get; private set; }
        public static List<Task> InProgressList { get; private set; }
        public static List<Task> DoneList { get; private set; }

        static TaskListViewModel()
        {
            ToDoList = new List<Task>();
            InProgressList = new List<Task>();
            DoneList = new List<Task>();
        }

        public static void UpdateLists(ITaskService taskService)
        {
            ToDoList = taskService.GetByCondition(t => t.Board.Title == "TODO").ToList();
            InProgressList = taskService.GetByCondition(t => t.Board.Title == "INPR").ToList();
            DoneList = taskService.GetByCondition(t => t.Board.Title == "DONE").ToList();
        }
    }
}


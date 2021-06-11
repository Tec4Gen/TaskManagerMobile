using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SSU.TaskManager.Entities;
using SSU.TaskManager.Common.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SSU.TaskManager.BusinessLogic.ServiceInterface;

namespace SSU.TaskManager.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskDescriptionView : ContentPage
    {
        private readonly Task _task;

        public TaskDescriptionView()
        {
            InitializeComponent();
        }

        public TaskDescriptionView(Task task)
            :this()
        {
            _task = task;

            taskTitle.Text = task.Title;
            description.Text = task.Description;
            datePicker.Date = DateTime.Parse(task.DeadLine);
        }

        public async void OnSaveChanges_Clicked(object sender, EventArgs e)
        {
            //var BoardLogic = DependenciesResolver.Kernel.GetService<IBoardService>();

            //var board = BoardLogic.GetById(1);

            //var task = new Task
            //{
            //    Group = null,
            //    GroupId = null,

            //    Title = taskTitle.Text,
            //    DeadLine = datePicker.Date.ToString("mm/dd/yyyy"),
            //    Board = board,
            //    BoardId = board.Id
            //};
            //var TaskLogic = DependenciesResolver.Kernel.GetService<ITaskService>();

            //TaskLogic.Update(task);
        }

        public async void MoveInToDo_Clicked(object sender, EventArgs e)
        {

        }

        public async void MoveInInProgress_Clicked(object sender, EventArgs e)
        {

        }

        public async void MoveInDone_Clicked(object sender, EventArgs e)
        {

        }
    }
}
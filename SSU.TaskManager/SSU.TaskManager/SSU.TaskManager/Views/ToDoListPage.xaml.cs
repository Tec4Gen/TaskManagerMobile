using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SSU.TaskManager.BusinessLogic.ServiceInterface;
using SSU.TaskManager.Common.Ioc;
using SSU.TaskManager.Entities;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SSU.TaskManager.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToDoListPage : ContentPage
    {
        private readonly ITaskService _taskService;
        private readonly IBoardService _boardService;

        private int _idUser = TabbedPageTaskList.IdUser;
        private string _taskName;

        public List<Task> Tasks { get; set; } = new List<Task>();

        public ToDoListPage()
        {
            InitializeComponent();

            this.BindingContext = this;

            _taskService = DependenciesResolver.Kernel.GetService<ITaskService>();
            _boardService = DependenciesResolver.Kernel.GetService<IBoardService>();

            Tasks.Add(new Task { Title = "Task 1" });
            Tasks.Add(new Task { Title = "Task 2" });
            Tasks.Add(new Task { Title = "Task 3" });

        }

        public async void OnDescription_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var stackLayout = btn.Parent as StackLayout;
            var label = stackLayout.FindByName("LabelTask") as Label;
            Task task = _taskService.GetByCondition(t => t.Title == label.Text).FirstOrDefault();
            //var task = new Task
            //{
            //    Title = btn.Text,
            //    Description = "Типа описание",
            //    DeadLine = DateTime.Now.ToString(),
            //};

            var taskDescriptionView = new TaskDescriptionView(task);

            await Navigation.PushAsync(taskDescriptionView);
        }

        private void TaskName_Completed(object sender, EventArgs e)
        {
            _taskName = ((Entry)sender).Text;
        }


        public async void OnAddTask_Clicked(object sender, EventArgs e)
        {
            if (_taskName != null)
            {
                var board = _boardService.GetByCondition(b => b.Title == "TODO").FirstOrDefault();

                var task = new Task
                {
                    Title = _taskName,
                    BoardId = board.Id,
                    Board = board
                };

                _taskService.Add(task);
            }
            else
            {
                await DisplayAlert("Alert", "Entry field is empty", "OK");
            }
        }
    }
}
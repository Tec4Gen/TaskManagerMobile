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

        public List<Task> Tasks { get; private set; }

        public ToDoListPage()
        {
            InitializeComponent();

            this.BindingContext = this;

            _taskService = DependenciesResolver.Kernel.GetService<ITaskService>();
            _boardService = DependenciesResolver.Kernel.GetService<IBoardService>();

            Tasks = _taskService.GetByCondition(t => t.Board.Title == "TODO").ToList();

        }

        public async void OnDescription_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;

            var task = new Task
            {
                Title = btn.Text,
                Description = "Типа описание",
                DeadLine = DateTime.Now.ToString(),
            };

            var taskDescriptionView = new TaskDescriptionView(task);

            await Navigation.PushAsync(taskDescriptionView);
        }

        public async void OnAddTask_Clicked(object sender, EventArgs e)
        {
            var entry = sender as Entry;

            if (entry.Text != string.Empty)
            {
                var board = _boardService.GetByCondition(b => b.Title == "TODO").FirstOrDefault();

                var task = new Task
                {
                    Title = entry.Text,
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
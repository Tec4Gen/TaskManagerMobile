using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SSU.TaskManager.Entities;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SSU.TaskManager.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToDoListPage : ContentPage
    {
        public ToDoListPage()
        {
            InitializeComponent();
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
            
        }
    }
}
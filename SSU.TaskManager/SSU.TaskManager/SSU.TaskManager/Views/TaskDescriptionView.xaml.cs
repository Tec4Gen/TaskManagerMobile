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

        public async void OnDescription_Changed(object sender, EventArgs e)
        {
        }

        public async void OnDate_Selected(object sender, EventArgs e)
        {
        }

        public async void OnSaveChanges_Clicked(object sender, EventArgs e)
        {
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
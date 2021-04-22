using SSU.TaskManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SSU.TaskManager.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public async void OnRegistration_Clicked(object sender, EventArgs e)
        {
            var destination = new RegistrationPage();
            await this.Navigation.PushAsync(destination);
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            var destination = new TabbedPageTaskList();
            await this.Navigation.PushAsync(destination);
        }
    }
}
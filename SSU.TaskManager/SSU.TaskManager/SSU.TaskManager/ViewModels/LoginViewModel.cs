using SSU.TaskManager.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SSU.TaskManager.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public Command RegisterCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            RegisterCommand = new Command(OnRegistrationLinkClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }

        private async void OnRegistrationLinkClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(RegistrationPage)}");
        }
    }
}

using SSU.TaskManager.Services;
using SSU.TaskManager.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SSU.TaskManager
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            var loginPage = new LoginPage();
            var navigationPage = new NavigationPage(loginPage);
            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

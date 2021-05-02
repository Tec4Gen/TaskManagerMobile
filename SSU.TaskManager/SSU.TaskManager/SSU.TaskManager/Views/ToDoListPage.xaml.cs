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
    public partial class ToDoListPage : ContentPage
    {
        public ToDoListPage()
        {
            InitializeComponent();
        }

        public async void MoveTaskInProgress_Clicked(object sender, EventArgs e)
        {
            
        }

        public async void OnBtClick(object sender, EventArgs e)
        {
            var btn = sender as Button;

            await Navigation.PushAsync(new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Button {

                            Text = btn.Text
                        },
                        new Button {

                           Text = btn.Text
                        },
                        new Button {

                            Text = btn.Text
                        }
                    }
                }
            });
        }
    }
}
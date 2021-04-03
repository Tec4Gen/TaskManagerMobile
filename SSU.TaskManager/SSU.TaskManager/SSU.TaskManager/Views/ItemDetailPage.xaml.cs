using SSU.TaskManager.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SSU.TaskManager.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
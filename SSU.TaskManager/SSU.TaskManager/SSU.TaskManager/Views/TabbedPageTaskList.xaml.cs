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
    public partial class TabbedPageTaskList : TabbedPage
    {
        public static int IdUser { get; set; }
        public TabbedPageTaskList(int id)
        {
            InitializeComponent();
        }
    }
}
using Xamarin.Forms;

namespace Roster.Client.Views
{
    [System.ComponentModel.DesignTimeVisible(false)]
    public partial class HomeView : ContentPage
    {
        Label label;
        public HomeView()
        {
            InitializeComponent();
            BindingContext = new { Title = "Roster App" };
            Title = "Roster App";
        }
    }
}
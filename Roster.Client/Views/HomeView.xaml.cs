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

            BindingContext = this.Title = "Roster App";
            label = new Label();
            label.SetBinding<HomeView>(Label.TextProperty, hv => hv.Title, mode: BindingMode.OneWay);
        }
    }
}
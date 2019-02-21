using Xamarin.Forms;

namespace XamarinLocalization.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;

            loveLabel.Text = AppResources.love;
        }
    }
}

using XamarinLocalization.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinLocalization.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinLocalization
{
    public partial class App : Application
    {
        public App()
        {
            InitLocalization();
            InitializeComponent();

            MainPage = new MainPage();
        }

        private void InitLocalization()
        {
            var ci = DependencyService.Get<ILocalizeService>().GetCurrentCultureInfo();
            AppResources.Culture = ci;
            DependencyService.Get<ILocalizeService>().SetLocale(ci);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

using System.Collections.Generic;
using System.Globalization;
using Xamarin.Forms;

namespace XamarinLocalization
{
    public partial class MainPage : ContentPage
    {
        private readonly List<string> languages = new List<string> { "", "es", "fr", "pt-BR" };
        private string selectedLanguage;

        public List<string> Languages 
        {
            get => this.languages;
        }

        public string SelectedLanguage 
        {
            get => this.selectedLanguage;
            set
            {
                this.selectedLanguage = value;
                OnPropertyChanged();
                SelectAppResources();
                ChangeResources(); 
            }
        }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            ChangeResources();
        }

        private void SelectAppResources()
        {
            if (string.IsNullOrWhiteSpace(SelectedLanguage))
                AppResources.Culture = CultureInfo.CurrentCulture;
            else
                AppResources.Culture = new CultureInfo(this.selectedLanguage);
        }

        private void ChangeResources()
        {
            languageSelectorPicker.Title = AppResources.language;
            loveLabel.Text = AppResources.love;
        }
    }
}

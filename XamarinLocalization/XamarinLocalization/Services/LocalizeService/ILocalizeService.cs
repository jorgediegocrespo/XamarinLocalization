using System.Globalization;

namespace XamarinLocalization.Services
{
    public interface ILocalizeService
    {
        CultureInfo GetCurrentCultureInfo();
        void SetLocale(CultureInfo ci);
    }
}

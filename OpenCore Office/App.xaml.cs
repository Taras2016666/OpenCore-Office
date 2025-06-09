using System.Globalization;

namespace OpenCore_Office
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Set default language to Ukrainian
            var culture = new CultureInfo("uk");
            LocalizationResourceManager.Instance.SetCulture(culture);

            MainPage = new AppShell();
        }
    }
}

using System.Globalization;
using Microsoft.Maui.Controls;

namespace OpenCore_Office.Pages
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            LanguagePicker.SelectedIndex = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "uk" ? 0 : 1;
        }

        private void OnLanguageChanged(object sender, EventArgs e)
        {
            var selected = LanguagePicker.SelectedIndex;
            var culture = selected == 0 ? "uk" : "en";
            if (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName != culture)
            {
                LocalizationResourceManager.Instance.SetCulture(new CultureInfo(culture));
                Application.Current.MainPage = new AppShell(); // Reload UI
            }
        }
    }
}
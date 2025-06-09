using Microsoft.Maui.Controls;

namespace OpenCore_Office.Pages
{
    public partial class PresentationPage : ContentPage
    {
        public PresentationPage()
        {
            InitializeComponent();
        }

        private async void OnOpenClicked(object sender, EventArgs e)
        {
            await DisplayAlert(LocalizationResourceManager.Instance["Open"], 
                "Функція відкриття презентації ще не реалізована.", "OK");
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            await DisplayAlert(LocalizationResourceManager.Instance["Save"], 
                "Функція збереження презентації ще не реалізована.", "OK");
        }
    }
}
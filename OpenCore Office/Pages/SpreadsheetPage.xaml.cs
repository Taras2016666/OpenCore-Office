using Microsoft.Maui.Controls;

namespace OpenCore_Office.Pages
{
    public partial class SpreadsheetPage : ContentPage
    {
        public SpreadsheetPage()
        {
            InitializeComponent();
        }

        private async void OnOpenClicked(object sender, EventArgs e)
        {
            await DisplayAlert(LocalizationResourceManager.Instance["Open"], 
                "Функція відкриття таблиці ще не реалізована.", "OK");
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            await DisplayAlert(LocalizationResourceManager.Instance["Save"], 
                "Функція збереження таблиці ще не реалізована.", "OK");
        }
    }
}
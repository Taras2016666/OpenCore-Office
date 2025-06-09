using Microsoft.Maui.Controls;

namespace OpenCore_Office.Pages
{
    public partial class TextEditorPage : ContentPage
    {
        public TextEditorPage()
        {
            InitializeComponent();
        }

        private async void OnOpenClicked(object sender, EventArgs e)
        {
            await DisplayAlert(LocalizationResourceManager.Instance["Open"], 
                "Функція відкриття файлу ще не реалізована.", "OK");
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            await DisplayAlert(LocalizationResourceManager.Instance["Save"], 
                "Функція збереження файлу ще не реалізована.", "OK");
        }
    }
}
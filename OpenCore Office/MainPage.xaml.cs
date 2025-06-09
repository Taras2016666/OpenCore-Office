using System;
using Microsoft.Maui.Controls;

namespace OpenCore_Office
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnTextEditorClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.TextEditorPage());
        }

        private async void OnSpreadsheetClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.SpreadsheetPage());
        }

        private async void OnPresentationClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.PresentationPage());
        }

        private async void OnSettingsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.SettingsPage());
        }
    }
}

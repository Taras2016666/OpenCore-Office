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
            // TODO: Implement spreadsheet open logic
            await DisplayAlert("Open", "Open spreadsheet functionality is not implemented.", "OK");
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            // TODO: Implement spreadsheet save logic
            await DisplayAlert("Save", "Save spreadsheet functionality is not implemented.", "OK");
        }
    }
}
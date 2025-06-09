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
            // TODO: Implement file open logic
            await DisplayAlert("Open", "Open file functionality is not implemented.", "OK");
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            // TODO: Implement file save logic
            await DisplayAlert("Save", "Save file functionality is not implemented.", "OK");
        }
    }
}
using Microsoft.Maui.Controls;

namespace OpenCore_Office;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnTextEditorClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OpenCoreOffice.Pages.TextEditorPage());
    }

    private async void OnSpreadsheetClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OpenCoreOffice.Pages.SpreadsheetPage());
    }

    private async void OnPresentationClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OpenCoreOffice.Pages.PresentationPage());
    }
}
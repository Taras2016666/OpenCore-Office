using System.Windows;
using OpenCoreOffice.Wpf.Views;

namespace OpenCoreOffice.Wpf;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MainContent.Content = new TextEditorView();
    }

    private void Exit_Click(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }

    private void TextEditor_Click(object sender, RoutedEventArgs e)
    {
        MainContent.Content = new TextEditorView();
    }

    private void Spreadsheet_Click(object sender, RoutedEventArgs e)
    {
        MainContent.Content = new SpreadsheetView();
    }

    private void Presentation_Click(object sender, RoutedEventArgs e)
    {
        MainContent.Content = new PresentationView();
    }
}
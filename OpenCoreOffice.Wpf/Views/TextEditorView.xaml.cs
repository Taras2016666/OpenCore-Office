using System.Windows;
using System.Windows.Controls;

namespace OpenCoreOffice.Wpf.Views;

public partial class TextEditorView : UserControl
{
    public TextEditorView()
    {
        InitializeComponent();
    }

    private void Open_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Open file functionality is not implemented.", "Open", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void Save_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Save file functionality is not implemented.", "Save", MessageBoxButton.OK, MessageBoxImage.Information);
    }
}
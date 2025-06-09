using System.Windows;
using System.Windows.Controls;

namespace OpenCoreOffice.Wpf.Views;

public partial class SpreadsheetView : UserControl
{
    public SpreadsheetView()
    {
        InitializeComponent();
    }

    private void Open_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Open spreadsheet functionality is not implemented.", "Open", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void Save_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Save spreadsheet functionality is not implemented.", "Save", MessageBoxButton.OK, MessageBoxImage.Information);
    }
}
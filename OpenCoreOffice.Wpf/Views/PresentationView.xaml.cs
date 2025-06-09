using System.Windows;
using System.Windows.Controls;

namespace OpenCoreOffice.Wpf.Views;

public partial class PresentationView : UserControl
{
    public PresentationView()
    {
        InitializeComponent();
    }

    private void Open_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Open presentation functionality is not implemented.", "Open", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void Save_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Save presentation functionality is not implemented.", "Save", MessageBoxButton.OK, MessageBoxImage.Information);
    }
}
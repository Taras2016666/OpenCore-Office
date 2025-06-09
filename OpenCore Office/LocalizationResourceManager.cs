using System.ComponentModel;
using System.Globalization;
using System.Resources;
// Ensure this using matches the namespace in Resources.Designer.cs:
using OpenCore_Office.Resources.Languages;

namespace OpenCore_Office;

public class LocalizationResourceManager : INotifyPropertyChanged
{
    public static LocalizationResourceManager Instance { get; } = new();

    // Use the correct fully qualified name for the Resources class.
    private readonly ResourceManager _resourceManager = Resources.ResourceManager;

    public string this[string text]
        => _resourceManager.GetString(text, CultureInfo.CurrentUICulture) ?? $"[{text}]";

    public event PropertyChangedEventHandler? PropertyChanged;

    public void SetCulture(CultureInfo culture)
    {
        CultureInfo.DefaultThreadCurrentUICulture = culture;
        CultureInfo.DefaultThreadCurrentCulture = culture;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
    }
}
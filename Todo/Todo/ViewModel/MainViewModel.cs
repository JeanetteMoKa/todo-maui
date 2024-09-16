using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Todo.ViewModel;

public class MainViewModel : INotifyPropertyChanged
{
    private string text;

    public string Text
    {
        get => text;
        set
        {
            text = value;
            OnPropertyChanged(nameof(Text));
        }
    }
    
    public event PropertyChangedEventHandler PropertyChanged;
    void OnPropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
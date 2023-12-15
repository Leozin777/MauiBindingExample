using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiApp1.ViewModel;

internal class MainPageViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private string _textForBinding;
    public string TextForBinding
    {
        get => _textForBinding;
        set
        {
            _textForBinding = value;
            this.OnPropertyChanged();
        }
    }

}

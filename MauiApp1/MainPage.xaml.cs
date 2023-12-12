using MauiApp1.ViewModel;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    //This property cannot be here because you set, on componentTest, itself as bindingcontext

    //private string _textForBinding;
    //   public string textForBinding 
    //{
    //	get => _textForBinding;
    //	set
    //	{
    //		_textForBinding = value;
    //		OnPropertyChanged();
    //	} 
    //}

    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        (this.BindingContext as MainPageViewModel).TextForBinding = "test";

        //This is not the best way, only for study
        //textForBinding = "test";
    }
}


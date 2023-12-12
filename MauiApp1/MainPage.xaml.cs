namespace MauiApp1;

public partial class MainPage : ContentPage
{
	private string _textForBinding;
    public string textForBinding 
	{
		get => _textForBinding;
		set
		{
			_textForBinding = value;
			OnPropertyChanged();
		} 
	}

    public MainPage()
	{
		InitializeComponent();
		BindingContext = this;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        textForBinding = "test";
    }
}


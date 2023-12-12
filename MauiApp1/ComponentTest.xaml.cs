namespace MauiApp1;

public partial class ComponentTest : ContentView
{
    public string C_TextBin 
	{
		get => (string)GetValue(C_TextBinProperty);
		set => SetValue(C_TextBinProperty, value);
	}

	public static BindableProperty C_TextBinProperty = BindableProperty.Create(nameof(C_TextBin), 
		typeof(string), typeof(ComponentTest), default(string), BindingMode.OneWay);

    public ComponentTest()
	{
		InitializeComponent();
		BindingContext = this;
	}
}
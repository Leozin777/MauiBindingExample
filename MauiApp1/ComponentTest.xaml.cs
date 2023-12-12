

namespace MauiApp1;

public partial class ComponentTest : ContentView
{

    public static BindableProperty ComponentTextProperty = BindableProperty.Create(nameof(ComponentText), typeof(string), typeof(ComponentTest), default(string), BindingMode.OneWay, propertyChanged: OnComponentTextChanged);

    private static void OnComponentTextChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is ComponentTest componentTest)
            componentTest.MyComponentLabel.Text = newValue.ToString();
    }

    public string ComponentText
    {
        get { return (string)GetValue(ComponentTextProperty); }
        set { SetValue(ComponentTextProperty, value); }
    }

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
    }
}
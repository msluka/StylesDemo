namespace StylesDemo;

public partial class DynamicStyleView : ContentPage
{
	public DynamicStyleView()
	{
		InitializeComponent();
	}

    private void Btn_Clicked(object sender, EventArgs e)
    {	
		Resources["dynamicStyle"] = Resources["greenStyle"];
    }

    private void Btn_Clicked_back(object sender, EventArgs e)
    {
        Application.Current.Resources.TryGetValue("specialBtn", out var newStyle);
        Resources["dynamicStyle"] = newStyle;

    }
}
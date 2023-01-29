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
}
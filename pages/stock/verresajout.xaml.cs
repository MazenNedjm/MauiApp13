using Mopups.Services;

namespace MauiApp13.pages.stock;

public partial class verresajout 
{
	public verresajout()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();

    }
}
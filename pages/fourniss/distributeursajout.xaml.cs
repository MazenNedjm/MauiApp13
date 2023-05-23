using Mopups.Services;

namespace MauiApp13.pages.fourniss;

public partial class distributeursajout 
{
	public distributeursajout()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();

    }
}
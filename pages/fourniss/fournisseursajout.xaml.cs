using Mopups.Services;

namespace MauiApp13.pages.fourniss;

public partial class fournisseursajout 
{
	public fournisseursajout()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();

    }
}
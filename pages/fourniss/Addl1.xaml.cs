using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Storage;
namespace MauiApp13.pages.fourniss;

public partial class Addl1 : Popup
{
	public Addl1()
	{
		InitializeComponent();
	}
	private async void Onlogoclicked(object sender, EventArgs e)
	{
		var resault = await FilePicker.PickAsync(new PickOptions
		{
			PickerTitle="give me please" , FileTypes = FilePickerFileType.Images
		});
		if (resault == null)
			return;
		var img = await resault.OpenReadAsync();
		logolab.Source = ImageSource.FromStream(() => img);
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Close();

    }
}
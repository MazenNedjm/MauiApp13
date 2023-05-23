using Mopups.Services;

namespace MauiApp13.pages.fourniss;

public partial class laboratoiresajout 
{
	public laboratoiresajout()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();

    }
    private async void Onlogoclicked(object sender, EventArgs e)
    {
        var resault = await FilePicker.PickAsync(new PickOptions
        {
            PickerTitle = "give me please",
            FileTypes = FilePickerFileType.Images
        });
        if (resault == null)
            return;
        var img = await resault.OpenReadAsync();
        logolab.Source = ImageSource.FromStream(() => img);
    }
}
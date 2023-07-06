using CommunityToolkit.Maui.Views;
using MauiApp13.pages;
using MauiApp13.pages.fourniss;
using Mopups.Services;
namespace MauiApp13;

public partial class MainPage : ContentPage

{
	int count = 0;

	public MainPage()
	{

		
		InitializeComponent();
        NavigationPage.SetHasBackButton(this, false);
        NavigationPage.SetHasNavigationBar(this, false);

    }

	private async void OnCounterClicked(object sender, EventArgs e)

	{

        await Navigation.PushAsync(new testzest(),false);
		
    }
	private void Onclicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new pages.fourniss.exom());
    }
    private void Onpop(object sender, EventArgs e)
    {
       // MopupService.Instance.PushAsync(new pages.fourniss.Addl1());
    }
    private void Onpop1(object sender, EventArgs e)
    {
        MopupService.Instance.PushAsync(new pages.vente.ventenew());
    }
    private void Onpop2(object sender, EventArgs e)
    {
        MopupService.Instance.PushAsync(new pages.prix.typedeverresajout());
    }



}


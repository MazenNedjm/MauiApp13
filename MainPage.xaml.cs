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
		

        await Navigation.PushAsync(new secondmain(),false);
		
    }
	private void Onclicked(object sender, EventArgs e)
	{
		
	}
    
    

}


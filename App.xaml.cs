namespace MauiApp13;

using Microsoft.Maui;
using Microsoft.Maui.LifecycleEvents;


public partial class App : Application

{


public App()
	{
		InitializeComponent();


        MainPage = new AppShell();

	}
    protected override Window CreateWindow(IActivationState activationState)
    {

        var window = base.CreateWindow(activationState);

        

        return window;
    }

}

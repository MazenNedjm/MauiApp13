using MauiApp13.pages.fourniss;
 

namespace MauiApp13.pages;

public partial class testzest : ContentPage
{
    int a=0;
    int b=0;
	public testzest()
	{
		InitializeComponent();

        home1.IsVisible = false;
        stock1.IsVisible = false;
        patiant1.IsVisible = false;
        fourniss1.IsVisible = false;
        stat1.IsVisible = false;
        prix1.IsVisible = false;


        var page1 = new pages.fourniss.Addl1();
        customView.Content = page1;
    }
    void OnToggleClicked()
    {
        if (a == 0)
        {
            Onplus();
            a = 1;
        }else if (a == 1)
        {
            Onminus();
            a = 0;
        }
         

    }
    void Onplus( )
    {
        myGrid.ColumnDefinitions.Clear();

        myGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new Microsoft.Maui.GridLength(19.9, Microsoft.Maui.GridUnitType.Star) });
        myGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new Microsoft.Maui.GridLength(80, Microsoft.Maui.GridUnitType.Star) });
        myGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new Microsoft.Maui.GridLength(0.1, Microsoft.Maui.GridUnitType.Star) });
        
        home1.IsVisible= true;
        stock1.IsVisible= true;
        patiant1.IsVisible = true; 
        fourniss1.IsVisible = true;
        stat1.IsVisible = true;
        prix1.IsVisible = true;
    }
    void Onminus()
    {
        myGrid.ColumnDefinitions.Clear();

        myGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new Microsoft.Maui.GridLength(4.9, Microsoft.Maui.GridUnitType.Star) });
        myGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new Microsoft.Maui.GridLength(95, Microsoft.Maui.GridUnitType.Star) });
        myGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new Microsoft.Maui.GridLength(0.1, Microsoft.Maui.GridUnitType.Star) });

        home1.IsVisible = false;
        stock1.IsVisible = false;
        patiant1.IsVisible = false;
        fourniss1.IsVisible = false;
        stat1.IsVisible = false;
        prix1.IsVisible = false;


    }
    void FrameShrink()
    {
        switch (b)
        {
            case 0:
                // Code to be executed if expression matches value1

                break;
            case 1:
                // Code to be executed if expression matches value2
                break;
            case 2:
                // Code to be executed if expression matches value1
                break;
            case 3:
                // Code to be executed if expression matches value2
                break;
            case 4:
                // Code to be executed if expression matches value1
                break;
            case 5:
                // Code to be executed if expression matches value2
                break;
                // Add more cases as needed
            default:
                // Code to be executed if expression does not match any case
                break;
        }

    }
    private void TrandparentAll()
    {
        // Perform button functionality or navigation logic here

        // Visual changes to simulate button behavior
        home.BackgroundColor = Colors.Transparent;
        stock.BackgroundColor = Colors.Transparent;
        fourniss.BackgroundColor = Colors.Transparent;
        patient.BackgroundColor = Colors.Transparent;
        stat.BackgroundColor = Colors.Transparent;
        prix.BackgroundColor = Colors.Transparent; 
    }
    private void home_Tapped(object sender, EventArgs e)
    {
        // d
        TrandparentAll();
        home.BackgroundColor = Color.FromHex("#4b4747");
        // Retrieve the Primary color value which is in the page's resource dictionary
        // Retrieve the Primary color value which is in the page's resource dictionary
        // Retrieve the Primary color value which is in the page's resource dictionary
        var hasValue = Resources.TryGetValue("DarkTheme.xaml", out object primaryColor);

        if (hasValue)
        {
            home.BackgroundColor  = (Color)primaryColor;
            home.BackgroundColor = Colors.AliceBlue;
        }


    }
    private void stock_Tapped(object sender, EventArgs e)
    {
        // d
        TrandparentAll();
        stock.BackgroundColor = Color.FromHex("#4b4747");
    }
    private void fourniss_Tapped(object sender, EventArgs e)
    {
        // d
        TrandparentAll();
        fourniss.BackgroundColor = Color.FromHex("#4b4747");
    }
    private void patiant_Tapped(object sender, EventArgs e)
    {
        // d
        TrandparentAll();
        patient.BackgroundColor = Color.FromHex("#4b4747");
    }
    private void stat_Tapped(object sender, EventArgs e)
    {
        // d
        TrandparentAll();
        stat.BackgroundColor = Color.FromHex("#4b4747");
    }
    private void prix_Tapped(object sender, EventArgs e)
    {
        // d
        TrandparentAll();
        prix.BackgroundColor = Color.FromHex("#E8E8E8");
    }
    private void sliding(object sender, EventArgs e)
    {
        // d
        // d
        OnToggleClicked();
    }
}
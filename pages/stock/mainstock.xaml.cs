namespace MauiApp13.pages.stock;

public partial class mainstock : ContentView
{
	public mainstock()
	{
		InitializeComponent();
         
  

    }
    public int c = 1;
    public void verresclicked(object sender, EventArgs e)
    {
        c = 1;

    }
    public void lentillesclicked(object sender, EventArgs e)
    {
        c = 2;

    }
    public void monturesclicked(object sender, EventArgs e)
    {
        c = 3;

    }
    public void autreclicked(object sender, EventArgs e)
    {
        c = 4;

    }
}
namespace MauiApp13.pages.fourniss;

public partial class mainpagefournisseurs : ContentView
{
	public mainpagefournisseurs()
	{
		InitializeComponent();
	}
    int c = 1;
    public void fournisseursclicked(object sender, EventArgs e)
    {
        c = 1;

    }
    public void laboratoiresclicked(object sender, EventArgs e)
    {
        c = 2;

    }
    public void distributeursclicked(object sender, EventArgs e)
    {
        c = 3;

    }
    public void cataloguesclicked(object sender, EventArgs e)
    {
        c = 4;

    }
}
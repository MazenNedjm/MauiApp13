namespace MauiApp13.pages.vente;

public partial class ventenew 
{
	public ventenew()
	{
		InitializeComponent();
        var page1 = new correction();
        var page2 = new Typedeverre();
        ContentFrame.Content = page1;
    }
    public void oncorrection(object sender, EventArgs e)
    {
        var page11 = new correction();
        ContentFrame.Content = page11;
    }

    public void onTypedeverre(object sender, EventArgs e)
    {
        var page2 = new Typedeverre();
        ContentFrame.Content = page2;
    }
}
 

namespace MauiApp13.pages.vente;

public partial class ventenew 
{
	public ventenew()
	{
		InitializeComponent();
        var page1 = new correction(); 
        ContentFrame.Content = page1;
    }
    public async void oncorrection(object sender, EventArgs e)
    {
        var page11 = new correction();
        ContentFrame.Content = page11;
 
        // making animation
        double translationY = +73;
        int durationMilliseconds = 200;
        int durationMillisecondss = 0;
        await ContentFrame.TranslateTo(ContentFrame.TranslationX, translationY, (uint)durationMillisecondss);
         

        await ContentFrame.TranslateTo(ContentFrame.TranslationX, 0, (uint)durationMilliseconds);

    }

    public async void onTypedeverre(object sender, EventArgs e)
    {
        var page2 = new Typedeverre();
        ContentFrame.Content = page2;
        // making animation
        double translationY = +73;
        int durationMilliseconds = 200;
        int durationMillisecondss = 0;
        await ContentFrame.TranslateTo(ContentFrame.TranslationX, translationY, (uint)durationMillisecondss);


        await ContentFrame.TranslateTo(ContentFrame.TranslationX, 0, (uint)durationMilliseconds);
    }

    public async void onMonture(object sender, EventArgs e)
    {
        var page2 = new monture();
        ContentFrame.Content = page2;
        // making animation
        double translationY = +73;
        int durationMilliseconds = 200;
        int durationMillisecondss = 0;
        await ContentFrame.TranslateTo(ContentFrame.TranslationX, translationY, (uint)durationMillisecondss);


        await ContentFrame.TranslateTo(ContentFrame.TranslationX, 0, (uint)durationMilliseconds);
    }

    public async void onAutre(object sender, EventArgs e)
    {
        var page2 = new autre();
        ContentFrame.Content = page2;
        // making animation
        double translationY = +73;
        int durationMilliseconds = 200;
        int durationMillisecondss = 0;
        await ContentFrame.TranslateTo(ContentFrame.TranslationX, translationY, (uint)durationMillisecondss);


        await ContentFrame.TranslateTo(ContentFrame.TranslationX, 0, (uint)durationMilliseconds);
    }

    public async void onPanier(object sender, EventArgs e)
    {
        var page2 = new panier();
        ContentFrame.Content = page2;
        // making animation
        double translationY = +73;
        int durationMilliseconds = 200;
        int durationMillisecondss = 0;
        await ContentFrame.TranslateTo(ContentFrame.TranslationX, translationY, (uint)durationMillisecondss);


        await ContentFrame.TranslateTo(ContentFrame.TranslationX, 0, (uint)durationMilliseconds);
    }
}
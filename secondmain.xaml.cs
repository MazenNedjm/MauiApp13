using MauiApp13.pages.vente;
using Microsoft.Maui.Controls;
using Mopups.Services;
using System.ComponentModel;

namespace MauiApp13;

public partial class secondmain : ContentPage
{
    public string Data { get; set; }
    int c = 1;
    int f = 3;
    int s = 3;
    int p = 2;
    public secondmain()
	{
		InitializeComponent();
	}
    private async void stockclicked(object sender, EventArgs e)
    {
        c = 1;
        // changing the framecontent to mainstock
        var page1 = new pages.stock.mainstock();
        myFrame.Content = page1;
        // making animation
        double translationY = +500;
        int durationMilliseconds = 600;
        int durationMillisecondss = 0;
        await myFrame.TranslateTo(myFrame.TranslationX, translationY, (uint)durationMillisecondss);


        await myFrame.TranslateTo(myFrame.TranslationX, 0, (uint)durationMilliseconds);

    }
    private async void fournisseursclicked(object sender, EventArgs e)
    {
        c = 2;
        // changing the framecontent to mainpagefournisseurs
        var page2 = new pages.fourniss.mainpagefournisseurs();
        myFrame.Content = page2;
        // making animation
        double translationY = +500;
        int durationMilliseconds = 600;
        int durationMillisecondss = 0;
        await myFrame.TranslateTo(myFrame.TranslationX, translationY, (uint)durationMillisecondss);
        

        await myFrame.TranslateTo(myFrame.TranslationX, 0, (uint)durationMilliseconds);

    }
    private async void prixclicked(object sender, EventArgs e)
    {
        c = 3;
        // changing the framecontent to mainprix
        var page2 = new pages.prix.mainprix();
        myFrame.Content = page2;
        // making animation
        double translationY = +500;
        int durationMilliseconds = 600;
        int durationMillisecondss = 0;
        await myFrame.TranslateTo(myFrame.TranslationX, translationY, (uint)durationMillisecondss);


        await myFrame.TranslateTo(myFrame.TranslationX, 0, (uint)durationMilliseconds);

    }
    private async void venteclicked(object sender, EventArgs e)
    {
        c = 4;
        // changing the framecontent to mainvente
        var page2 = new pages.vente.mainvente();
        myFrame.Content = page2;
        // making animation
        double translationY = +500;
        int durationMilliseconds = 600;
        int durationMillisecondss = 0;
        await myFrame.TranslateTo(myFrame.TranslationX, translationY, (uint)durationMillisecondss);


        await myFrame.TranslateTo(myFrame.TranslationX, 0, (uint)durationMilliseconds);

    }

    private async void statistiqueclicked(object sender, EventArgs e)
    {
        c = 2;
        // changing the framecontent to mainstatistique
        var page2 = new pages.statistiques.mainstatistiques();
        myFrame.Content = page2;
        // making animation
        double translationY = +500;
        int durationMilliseconds = 600;
        int durationMillisecondss = 0;
        await myFrame.TranslateTo(myFrame.TranslationX, translationY, (uint)durationMillisecondss);


        await myFrame.TranslateTo(myFrame.TranslationX, 0, (uint)durationMilliseconds);

    }

    public void Onclicked(object sender, EventArgs e)
    {
        //when stock is clicked 
        if (c == 1)
        {
            if (s == 1)
            {
                MopupService.Instance.PushAsync(new pages.stock.verresajout());
            }
            if (s == 2)
            {
                MopupService.Instance.PushAsync(new pages.stock.lantillesajout()) ;
            }
            if (s == 3)
            {
                MopupService.Instance.PushAsync(new pages.stock.montureajout());
            }
            if (s == 4)
            {
                MopupService.Instance.PushAsync(new pages.stock.autreajout());
            }

        }
        //when fournisseurs is clicked 
        if (c == 2)
        {
            if (f == 1)
            {
                MopupService.Instance.PushAsync(new pages.fourniss.fournisseursajout());
            }
            if (f == 2)
            {
                MopupService.Instance.PushAsync(new pages.fourniss.laboratoiresajout());
            }
            if (f == 3)
            {
                MopupService.Instance.PushAsync(new pages.fourniss.distributeursajout());
            }
        }
        //when prix is clicked 
        if (c == 3)
        {
            if (p== 1) {
                MopupService.Instance.PushAsync(new pages.prix.typedeverresajout());
            }
            if (p == 2)
            {
                MopupService.Instance.PushAsync(new pages.prix.marquedemontureajout());
            }

        }
        //when vente is clicked 
        if (c == 4)
        {
            MopupService.Instance.PushAsync(new pages.vente.ventenew());
        }

    }


  

}
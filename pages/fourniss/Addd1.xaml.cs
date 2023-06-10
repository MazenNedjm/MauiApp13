using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls.Compatibility;
namespace MauiApp13.pages.fourniss;


public partial class Addd1 : ContentView

{
 
  

   

    public Addd1()
    {
        BindingContext = new distributeurviewmodel();
        InitializeComponent();
        
     


    }
    
}
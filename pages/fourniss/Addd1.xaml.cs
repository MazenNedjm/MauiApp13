using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls.Compatibility;
namespace MauiApp13.pages.fourniss;


public partial class Addd1 : ContentView

{


    public class Person
    {
        public string Name { get; set; }
        public int namber { get; set; }
        public int  Age { get; set; }
        public string dernierecorrection { get; set; }
       
        


    }


    

    public Addd1()
    {
        
        InitializeComponent();

        var people = new List<Person>
        {
            new Person { Name = "John Doe", Age = 30 },
           
        };

        BindableLayout.SetItemsSource(personFlexLayout, people);
    }
    
    


}
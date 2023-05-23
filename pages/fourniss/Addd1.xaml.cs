using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls.Compatibility;
namespace MauiApp13.pages.fourniss;


public partial class Addd1 : ContentView

{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();
  

    public ObservableCollection<string> Items { get; set; }

    public Addd1()
    {

        InitializeComponent();
        BindingContext = new distributeurviewmodel();
        People.Add(new Person { Name = "John", Age = 25 });
        People.Add(new Person { Name = "Alice", Age = 30 });
        People.Add(new Person { Name = "Bob", Age = 40 });
        People.Add(new Person { Name = "John", Age = 25 });
        People.Add(new Person { Name = "Alice", Age = 30 });
        People.Add(new Person { Name = "Bob", Age = 40 });
        People.Add(new Person { Name = "John", Age = 25 });
        People.Add(new Person { Name = "Alice", Age = 30 });
        People.Add(new Person { Name = "Bob", Age = 40 });
        People.Add(new Person { Name = "John", Age = 25 });
        People.Add(new Person { Name = "Alice", Age = 30 });
        People.Add(new Person { Name = "Bob", Age = 40 });
        People.Add(new Person { Name = "John", Age = 25 });
        People.Add(new Person { Name = "Alice", Age = 30 });
        People.Add(new Person { Name = "Bob", Age = 40 });
        People.Add(new Person { Name = "John", Age = 25 });
        People.Add(new Person { Name = "Alice", Age = 30 });
        People.Add(new Person { Name = "Bob", Age = 40 });

        // Set the ListView's ItemsSource property to the People collection
        Items = new ObservableCollection<string>()
            {
                "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6",
                "Item 7", "Item 8", "Item 9", "Item 10", "Item 11", "Item 12",
                "Item 13", "Item 14", "Item 15", "Item 16", "Item 17", "Item 18"
            };


    }
    
}
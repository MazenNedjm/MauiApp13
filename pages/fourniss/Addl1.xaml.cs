using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Storage;
namespace MauiApp13.pages.fourniss;

public partial class Addl1 : ContentView
{
 
    public Addl1()
	{
		InitializeComponent();
        var people = new List<Person>
            {
                new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                 new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                 new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                 new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                 new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 30 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },
                  new Person { Name = "KQMEEL Mahboul", Age = 12,namber= "Ophtalmologue"  ,dernierecorrection="Nbr d'ordonance :"  },
                new Person { Name = "BAZIN Salah", Age = 06 ,namber= "Optometriste"  ,dernierecorrection="Nbr d'ordonance :"  },

            };

       // myListView.ItemsSource = people;
     BindableLayout.SetItemsSource(myListView, people);

    }
    private void home_Tapped(object sender, EventArgs e)
    {
        // d
        
    }
    public class Person
    {
        public string Name { get; set; }
        public string namber { get; set; }
        public int Age { get; set; }
        public string dernierecorrection { get; set; }

    }
}
using Mopups.Services;
using System.Collections.ObjectModel;

namespace MauiApp13.pages.prix;

public partial class typedeverresajout 
{
    public ObservableCollection<Team> Teams { get; set; }
    
    
    public typedeverresajout()
	{
       
    
        
        InitializeComponent();
        Teams = new ObservableCollection<Team>()

        {
            new Team { G2 = "", G4 = "", G6 = "" ,G8 = "", G10 = "", G12 = "", G14 = "" ,G16 = "", G18 = "", G20 = "" },
            new Team { G2 = "", G4 = "", G6 = "" ,G8 = "", G10 = "", G12 = "", G14 = "" ,G16 = "", G18 = "", G20 = "" },
            new Team { G2 = "", G4 = "", G6 = "" ,G8 = "", G10 = "", G12 = "", G14 = "" ,G16 = "", G18 = "", G20 = "" },
            new Team { G2 = "", G4 = "", G6 = "" ,G8 = "", G10 = "", G12 = "", G14 = "" ,G16 = "", G18 = "", G20 = "" },
            new Team { G2 = "", G4 = "", G6 = "" ,G8 = "", G10 = "", G12 = "", G14 = "" ,G16 = "", G18 = "", G20 = "" },
            new Team { G2 = "", G4 = "", G6 = "" ,G8 = "", G10 = "", G12 = "", G14 = "" ,G16 = "", G18 = "", G20 = "" },
            // Add more items as needed
        };
         
        BindingContext = this;

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();
        
    }
    



}

public class Team
{
    public string G2 { get; set; }
    public string G4 { get; set; }
    public string G6 { get; set; }
    public string G8 { get; set; }
    public string G10 { get; set; }
    public string G12 { get; set; }
    public string G14 { get; set; }
    public string G16 { get; set; }
    public string G18 { get; set; }
    public string G20 { get; set; }
    

}
	
   

    


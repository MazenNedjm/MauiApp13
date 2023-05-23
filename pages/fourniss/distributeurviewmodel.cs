
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;


namespace MauiApp13.pages.fourniss
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class distributeurviewmodel :  INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropretyChanges;
        public event PropertyChangedEventHandler PropertyChanged;

        public distributeurviewmodel()
        {
            LoadData();

        }
        public ObservableCollection<String> Items { get; set; } = new ObservableCollection<String>();
        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();
        private void LoadData()
        {
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });

            Items.Add("trout");
            Items.Add("koko");
        }

        private string name;
        public string Name
        {
            get => name;
            set
            {
                if (name == value)
                    return;
                name = value;
                RaisPropretyChanged();
            }
        }

        private void RaisPropretyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}

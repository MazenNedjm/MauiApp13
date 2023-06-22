
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
        
        private bool isloading;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool Isloading
        {
            get { return isloading; }
            set
            {
                isloading = value;
                OnPropertyChanged(nameof(Isloading));
            }
        }

        public distributeurviewmodel()
        {
            Isloading = true;
            LoadData();
            Isloading = false;

        }
        
        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();
        public ObservableCollection<ObservableCollection<Person>> People1 { get; set; } = new ObservableCollection<ObservableCollection<Person>>();
        
        private void LoadData()
        {

            People.Add(new Person { Name = "John1", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John1", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John1", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John1", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John1", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John1", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John1", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John1", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John1", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John1", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John1", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John1", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John1", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John1", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John1", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John1", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });
            People.Add(new Person { Name = "John", Age = 25 });
            People.Add(new Person { Name = "Alice", Age = 30 });

            for (int i = 0; i < People.Count; i += 4)
            {
                var group = new ObservableCollection<Person>();

                for (int j = i; j < i + 4 && j < People.Count; j++)
                {
                    group.Add(People[j]);
                }

                People1.Add(group);
               
               

            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

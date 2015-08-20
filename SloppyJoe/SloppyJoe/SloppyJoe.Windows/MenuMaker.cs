using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SloppyJoe
{
    public class MenuItem
    {
        public string Bread
        {
            get; private set;
        }
        public string Condiment
        {
            get; private set;
        }
        public string Meat
        {
            get; private set;
        }

        public MenuItem(string meat, string condiment, string bread)
        {
            Meat = meat;
            Condiment = condiment;
            Bread = bread;
        }

        public override string ToString()
        {
            return Meat + " with " + Condiment + " on " + Bread;
        }
    }
    class MenuMaker : INotifyPropertyChanged
    {
        private Random random = new Random();
        private List<string> Meats = new List<string>(){ "Roast Beef", "Salami" , "Turkey" , "Ham" , "Pastrami" };
        private List<string> Condiments = new List<string>(){ "yellow mustard" , "brown mustard" , "honey mustard" ,
            "mayo" , "relish" , "french dressing" };
        private List<string> Breads = new List<string>() { "rye", "white", "wheat", "pumpernickel", "italien bread", "a roll" };

        public ObservableCollection<MenuItem> Menu { get; private set; }
        public DateTime GeneratedDate { get; private set; }
        public int NumberOfItems { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChangedEvent = PropertyChanged;
            if(propertyChangedEvent != null)
            {
                propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public MenuMaker()
        {
            Menu = new ObservableCollection<MenuItem>();
            NumberOfItems = 10;
            UpdateMenu();
        }

        public void UpdateMenu()
        {
            Menu.Clear();
            for (int i = 0; i < NumberOfItems; ++i)
                Menu.Add(CreateMenuItem());
            GeneratedDate = DateTime.Now;
            OnPropertyChanged("GeneratedDate");
        }

        public MenuItem CreateMenuItem()
        {
            string randomMeat = Meats[random.Next(Meats.Count)];
            string randomCondiment = Condiments[random.Next(Condiments.Count)];
            string randomBread = Breads[random.Next(Breads.Count)];

            return new MenuItem(randomMeat, randomCondiment, randomBread);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace amirtest2
{
    public class Program
    {
        public static ObservableCollection<testmodel> list = new ObservableCollection<testmodel>();

        public static void Main(string[] args)
        {
            

            list = new ObservableCollection<testmodel>();
            list.CollectionChanged += listChanged;


            list.Add(new testmodel { age = 19, name = "eric", phone = "0932052460" });

            foreach (var item in list)
            {
                item.age = 20;
                item.name = "erfan";
            }
            
            

        }
        public ObservableCollection<testmodel> List { get { return list; } }

        public void Clear() { list.Clear(); }

        private static void listChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (testmodel item in e.OldItems)
                {
                    //Removed items
                    item.PropertyChanged -= EntityViewModelPropertyChanged;
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (testmodel item in e.NewItems)
                {
                    //Added items
                    item.PropertyChanged += EntityViewModelPropertyChanged;
                }
            }            
        }

        public static void EntityViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {            
            Console.WriteLine(e.PropertyName);
        }
      
    }    
}
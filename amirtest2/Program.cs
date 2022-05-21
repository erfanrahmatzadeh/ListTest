using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

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

        private static void listChanged(object sender, NotifyCollectionChangedEventArgs args)
        {
            Console.WriteLine("this shit is working");
        }

        public static void CollectionChangedMethod(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Replace)
            {
                Console.WriteLine("this shit is working");
            }
        }
    }
}
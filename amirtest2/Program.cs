using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace amirtest2
{
    public class Program
    {
        public static List<testmodel> list = new List<testmodel>();

        public static void Main(string[] args)
        {

            list = new List<testmodel>();
            list.Add(new testmodel { age = 19, name = "eric", phone = "0932052460" });
            
            foreach(testmodel item in list)
            {
                item.PropertyChanged += Item_PropertyChanged;
            }

            foreach (var item in list)
            {
                item.age = 20;
                item.name = "erfan";
            }                        
        }

        private static void Item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine(e.PropertyName);
        }     
      
    }    
}
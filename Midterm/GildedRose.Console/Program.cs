using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using GoblinLib;

namespace GildedRose.Console
{
    public class Program
    {
        //Do not modify this line
        public GoblinInventory Inventory = new GoblinInventory();
        //-Goblin

        static void Main(string[] args)
        {
            Menu menu = new Menu();
            var app = new Program();

            app.Inventory.LoadInventory();
            ConcreteAggregate a = new ConcreteAggregate();

            System.Console.WriteLine("Welcome to the Gilded Rose\n");

            for (int i = 0; i < 31; ++i)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"-------- day {i} --------\n" +
                          $"name, sellIn, quality\n");

                foreach (var item in app.Inventory.Items)
                {
                    string name = $"{item.Name.ToString()} ";
                    string sellin = $"{item.SellIn.ToString()} ";
                    string quality = $"{item.Quality.ToString()} \n";
                    //string day = a[i].ToString();
                    sb.Append(name + sellin + quality);
                }

                a[i] = sb.ToString();
                menu.UpdateQuality(app);
                app.Inventory.SaveInventory();
            }

            // Create an iterator and loop over the list
            Iterator iterator = a.CreateIterator();

            for (object inventory_item = iterator.First(); inventory_item != null; inventory_item = iterator.Next())
            {
                System.Console.WriteLine(inventory_item);
            }

            System.Console.ReadKey();
        }
    }

}

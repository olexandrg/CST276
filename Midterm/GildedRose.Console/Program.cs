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
            // Create an object to interact with global inventory
            InventoryUpdater update = new InventoryUpdater();

            // Create an instance of a list to store each day
            ConcreteAggregate a = new ConcreteAggregate();

            // Select the number of days to run the inventory and print the changes
            update.RunInventory(a, 31);

            // Create an iterator and loop over the list
            Iterator iterator = a.CreateIterator();

            for (object i = iterator.First(); i != null; i = iterator.Next())
            {
                System.Console.WriteLine(i);
            }

            System.Console.ReadKey();
        }
    }

}

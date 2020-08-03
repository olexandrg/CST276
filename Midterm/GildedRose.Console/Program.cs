using System.Collections.Generic;
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
            menu.PrintIntroduction();

            menu.PrintItems();
        }
 
  

    }

}

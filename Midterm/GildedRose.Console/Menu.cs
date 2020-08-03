using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console
{
    public class Menu
    {
        private readonly Program game;
        public Menu()
        {
            this.game = new Program();
            game.Inventory.LoadInventory();

        }

        public void PrintIntroduction()
        {
            System.Console.WriteLine("Welcome to the Gilded Rose\n");
        }

        public void PrintItems()
        {
            for (int i = 0; i < 31; i++)
            {
                System.Console.WriteLine("-------- day " + i + " --------");
                System.Console.WriteLine("name, sellIn, quality");
                foreach (var item in game.Inventory.Items)
                {
                    System.Console.WriteLine(item.Name + ", " + item.SellIn + ", " + item.Quality);
                }
                System.Console.WriteLine();

                game.UpdateQuality();
            }

            game.Inventory.SaveInventory();

            System.Console.ReadLine();
        }
    }
}

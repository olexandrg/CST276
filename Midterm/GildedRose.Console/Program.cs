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
 
        public void UpdateQuality()
        {
            for (var i = 0; i < Inventory.Items.Count; i++)
            {
                if (Inventory.Items[i].Name != "Aged Brie" && Inventory.Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Inventory.Items[i].Quality > 0)
                    {
                        if (Inventory.Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            Inventory.Items[i].Quality = Inventory.Items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (Inventory.Items[i].Quality < 50)
                    {
                        Inventory.Items[i].Quality = Inventory.Items[i].Quality + 1;

                        if (Inventory.Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Inventory.Items[i].SellIn < 11)
                            {
                                if (Inventory.Items[i].Quality < 50)
                                {
                                    Inventory.Items[i].Quality = Inventory.Items[i].Quality + 1;
                                }
                            }

                            if (Inventory.Items[i].SellIn < 6)
                            {
                                if (Inventory.Items[i].Quality < 50)
                                {
                                    Inventory.Items[i].Quality = Inventory.Items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (Inventory.Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Inventory.Items[i].SellIn = Inventory.Items[i].SellIn - 1;
                }

                if (Inventory.Items[i].SellIn < 0)
                {
                    if (Inventory.Items[i].Name != "Aged Brie")
                    {
                        if (Inventory.Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Inventory.Items[i].Quality > 0)
                            {
                                if (Inventory.Items[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    Inventory.Items[i].Quality = Inventory.Items[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            Inventory.Items[i].Quality = Inventory.Items[i].Quality - Inventory.Items[i].Quality;
                        }
                    }
                    else
                    {
                        if (Inventory.Items[i].Quality < 50)
                        {
                            Inventory.Items[i].Quality = Inventory.Items[i].Quality + 1;
                        }
                    }
                }
            }
        }

    }

}

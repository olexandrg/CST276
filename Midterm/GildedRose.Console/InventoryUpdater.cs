using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoblinLib;

namespace GildedRose.Console
{
    public class InventoryUpdater
    {
        private Program app;

        //private List<string> items = new List<string>();

        public InventoryUpdater()
        {
            this.app = new Program();
            app.Inventory.LoadInventory();

            //items.Add("Aged Brie");
            //items.Add("Sulfuras, Hand of Ragnaros");
            //items.Add("Backstage passes to a TAFKAL80ETC concert");
            //items.Add("Conjured Mana Cake");
            //items.Add("Enchanted Shield");
        }

        public void RunInventory(ConcreteAggregate a, int days)
        {
            System.Console.WriteLine("Welcome to the Gilded Rose\n");

            for (int i = 0; i < days; ++i)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"-------- day {i} --------\n" +
                          "name, sellIn, quality\n");

                foreach (var item in app.Inventory.Items)
                {
                    string itemInfo = $"{item.Name} {item.SellIn} {item.Quality} \n";
                    sb.Append(itemInfo);
                }

                a[i] = sb.ToString();
                UpdateQuality(app);
                app.Inventory.SaveInventory();
            }
        }

        // get rid of the paramter before release (redundant, accessing member data)
        public void UpdateQuality(Program app)
        {
            
            foreach (var t in app.Inventory.Items)
            {
                if (t.Name.Contains("Aged"))
                {
                    AgedBrieUpdater updater = new AgedBrieUpdater();
                    updater.UpdateItem(t);
                }
                else if (t.Name.Contains("Backstage"))
                {
                    BackStageUpdater updater = new BackStageUpdater();
                    updater.UpdateItem(t);
                }
                else if (t.Name.Contains("Conjured"))
                {
                    ConjuredUpdater updater = new ConjuredUpdater();
                    updater.UpdateItem(t);
                }
                else if (t.Name.Contains("Enchanted"))
                {
                    EnchantedUpdater updater = new EnchantedUpdater();
                    updater.UpdateItem(t);
                }
                else if (t.Name.Contains("Sulfuras"))
                {
                    // Legendary Item
                }
                else
                {
                    ItemQualityUpdater updater = new ItemQualityUpdater();
                    updater.UpdateItem(t);
                }
                //if (t.Name != "Aged Brie" && t.Name != "Backstage passes to a TAFKAL80ETC concert")
                //{
                //    if (t.Quality > 0)
                //    {
                //        if (t.Name != "Sulfuras, Hand of Ragnaros")
                //        {
                //            t.Quality = t.Quality - 1;
                //        }
                //    }
                //}
                //else
                //{
                //    if (t.Quality < 50)
                //    {
                //        t.Quality = t.Quality + 1;

                //        if (t.Name == "Backstage passes to a TAFKAL80ETC concert")
                //        {
                //            if (t.SellIn < 11)
                //            {
                //                if (t.Quality < 50)
                //                {
                //                    t.Quality = t.Quality + 1;
                //                }
                //            }

                //            if (t.SellIn < 6)
                //            {
                //                if (t.Quality < 50)
                //                {
                //                    t.Quality = t.Quality + 1;
                //                }
                //            }
                //        }
                //    }
                //}

                //if (t.Name != "Sulfuras, Hand of Ragnaros")
                //{
                //    t.SellIn = t.SellIn - 1;
                //}

                //if (t.SellIn < 0)
                //{
                //    if (t.Name != "Aged Brie")
                //    {
                //        if (t.Name != "Backstage passes to a TAFKAL80ETC concert")
                //        {
                //            if (t.Quality > 0)
                //            {
                //                if (t.Name != "Sulfuras, Hand of Ragnaros")
                //                {
                //                    t.Quality = t.Quality - 1;
                //                }
                //            }
                //        }
                //        else
                //        {
                //            t.Quality = t.Quality - t.Quality;
                //        }
                //    }
                //    else
                //    {
                //        if (t.Quality < 50)
                //        {
                //            t.Quality = t.Quality + 1;
                //        }
                //    }
                //}
            }
        }
    }
}

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

        public InventoryUpdater()
        {
            this.app = new Program();
            app.Inventory.LoadInventory();
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

        public void UpdateQuality(Program app)
        {
            ItemNameStrategy update = new ItemQualityUpdater();

            foreach (var t in app.Inventory.Items)
            {
                update.ItemNameSelection(t);
            }
        }
    }
}

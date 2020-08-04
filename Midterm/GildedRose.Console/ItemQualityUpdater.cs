using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoblinLib;

namespace GildedRose.Console
{
    public class ItemQualityUpdater : ItemNameStrategy
    {
        public virtual void UpdateItem(Item t)
        {
            t.SellIn = t.SellIn - 1;
            if (t.SellIn <= 0)
            {
                t.Quality = t.Quality - 2;
            }
            else
            {
                t.Quality = t.Quality - 1;
            }
        }

        public void ItemNameSelection(Item t)
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
        }
    }
}

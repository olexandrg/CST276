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

        public void ItemNameSelection(Item item, decimal enchanted_count)
        {
            if (item.Name.Contains("Aged"))
            {
                AgedBrieUpdater updater = new AgedBrieUpdater();
                updater.UpdateItem(item);
            }
            else if (item.Name.Contains("Backstage"))
            {
                BackStageUpdater updater = new BackStageUpdater();
                updater.UpdateItem(item);
            }
            else if (item.Name.Contains("Conjured"))
            {
                ConjuredUpdater updater = new ConjuredUpdater();
                updater.UpdateItem(item);
            }
            else if (item.Name.Contains("Enchanted"))
            {
                EnchantedUpdater updater = new EnchantedUpdater();
                updater.UpdateItem(item, enchanted_count);
            }
            else if (!item.Name.Contains("Sulfuras"))
            {
                ItemQualityUpdater updater = new ItemQualityUpdater();
                updater.UpdateItem(item);
            }
        }

    }
}

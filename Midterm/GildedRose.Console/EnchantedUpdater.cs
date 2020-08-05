using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoblinLib;

namespace GildedRose.Console
{
    public class EnchantedUpdater
    {
        public void UpdateItem(Item t, decimal enchanted_count)
        {
            
            t.SellIn = t.SellIn - 1;

            if (t.SellIn > 0 && enchanted_count % 1 == 0)
            {
                t.Quality = t.Quality - 1;
            }
            else if (t.SellIn <= 0)
            {
                t.Quality = t.Quality - 1;
            }
        }
    }
}

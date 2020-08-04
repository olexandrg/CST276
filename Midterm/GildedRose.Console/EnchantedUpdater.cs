using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoblinLib;

namespace GildedRose.Console
{
    public class EnchantedUpdater : ItemQualityUpdater
    {
        public override void UpdateItem(Item t)
        {
            t.SellIn = t.SellIn - 1;
            t.Quality = t.Quality - 1;
        }
    }
}

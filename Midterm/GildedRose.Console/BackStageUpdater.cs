using GoblinLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console
{
    public class BackStageUpdater : ItemQualityUpdater
    {
        public override void UpdateItem(Item t)
        {
            if (t.SellIn > 10)
            {
                t.SellIn = t.SellIn - 1;
                t.Quality = t.Quality + 1;
            }
            else if (t.SellIn <= 10 && t.SellIn > 5)
            {
                t.SellIn = t.SellIn - 1;
                t.Quality = t.Quality + 2;
            }
            else if (t.SellIn <= 5 && t.SellIn > 0)
            {
                t.SellIn = t.SellIn - 1;
                t.Quality = t.Quality + 3;
            }
            else if (t.SellIn <= 0)
            {
                t.SellIn = t.SellIn - 1;
                t.Quality = 0;
            }
        }
    }
}

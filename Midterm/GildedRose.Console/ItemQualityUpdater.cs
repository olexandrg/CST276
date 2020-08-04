using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoblinLib;

namespace GildedRose.Console
{
    public class ItemQualityUpdater
    {

        public virtual void UpdateItem(Item t)
        {
            t.Quality = t.Quality - 1;
        }
    }
}

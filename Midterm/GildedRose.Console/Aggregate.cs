﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console
{
    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
}

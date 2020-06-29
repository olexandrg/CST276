﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockReportStrategies
{
    public interface IFilterStrategy
    {
        bool Include(TradingDay day);
    }
}

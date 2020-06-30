using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockReportStrategies
{
    public interface ICSVParser
    {
        void Parse(string filename, List<TradingDay> list);
    }
}
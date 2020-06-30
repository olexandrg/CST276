using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace StockReportStrategies
{
    public class StockMarket
    {
        List<TradingDay> tradingDays = new List<TradingDay>();

        public StockMarket(string filename, ICSVParser parser)
        {
            parser.Parse(filename, tradingDays);
        }

        /// <summary>
        /// Returns an iterator to iterate through each trading day
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TradingDay> GetTradingDays()
        {
            return tradingDays;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockReportStrategies;

namespace StrategyLabStarterCode
{
    class Program
    {
        private static void ReportTradingDays(StockMarket tradingDays)
        {
            foreach (TradingDay day in tradingDays.GetTradingDays())
            {
                IFilterStrategy tradingDay = new HighDailySwing();

                //check if each day has a high swing
                if (tradingDay.Include(day))
                {
                    Console.WriteLine(day.ToString());
                }
            }
        }

        static void Main(string[] args)
        {
            StockMarket tradingDays = new StockMarket(@"..\..\stockData.csv");

            ReportTradingDays(tradingDays);

            //Prevent the console window from closing during debugging. 
            Console.ReadLine();
        }        
    }
}

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
        // report days with high daily swing
        private static void ReportTradingDays(StockMarket tradingDays)
        {
            Console.WriteLine("High Swing Days: ");

            foreach (TradingDay day in tradingDays.GetTradingDays())
            {
                IFilterStrategy tradingDay = new HighDailySwing();

                if (tradingDay.Include(day))
                    Console.WriteLine(day.ToString());
            }
        }

        // report days with high trading volume
        private static void ReportHighVolumeDays(StockMarket tradingDays)
        {
            Console.WriteLine("\n" + "High Volume Days: ");

            foreach (TradingDay day in tradingDays.GetTradingDays())
            {
                IFilterStrategy tradingDay = new HighDailyVolume();

                if (tradingDay.Include(day))
                    Console.WriteLine(day.ToString());
            }
        }

        static void Main(string[] args)
        {
            StockMarket tradingDays = new StockMarket(@"..\..\stockData.csv");

            ReportTradingDays(tradingDays);
            ReportHighVolumeDays(tradingDays);

            //Prevent the console window from closing during debugging. 
            Console.ReadLine();
        }        
    }
}

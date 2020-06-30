using System;

namespace StockReportStrategies
{
    public class HighDailySwing: IFilterStrategy
    {
        bool IFilterStrategy.Include(TradingDay day, double swingFactor)
        {
            double swing = day.Open - day.Close;
            double percentageSwing = Math.Abs(swing / day.Open);

            if (percentageSwing > swingFactor)
                return true;
            return false;
        }
    }
}

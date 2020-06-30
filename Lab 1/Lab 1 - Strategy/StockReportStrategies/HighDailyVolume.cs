namespace StockReportStrategies
{
    public class HighDailyVolume : IFilterStrategy
    {
        bool IFilterStrategy.Include(TradingDay day, double dailyVolumeCap)
        {
            double volume = day.Volume;

            if (volume > dailyVolumeCap)
                return true;
            return false;
        }
    }
}

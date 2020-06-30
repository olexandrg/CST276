namespace StockReportStrategies
{
    public partial class HighDailyVolume : IFilterStrategy
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

namespace StockReportStrategies
{
    public class HighDailyVolume : IFilterStrategy
    {
        bool IFilterStrategy.Include(TradingDay day)
        {
            double volume = day.Volume;

            if (volume > DailyVolumeThreshold)
                return true;
            return false;
        }

        private const double DailyVolumeThreshold = 20000000;

    }
}

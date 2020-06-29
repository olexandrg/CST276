using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

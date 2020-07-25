using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using NUnit.Framework;
using StockReportStrategies;
using StrategyLabStarterCode;

namespace StockReportUnitTests
{
    public class StockReportTests
    {
        [Test]
        public void StockMarketConstructor()
        {
            // Arrange
            ICSVParser originalParser = new OriginalCSVParser();

            StockMarket test_market = new StockMarket("test_original.csv", originalParser);

            // Assert
            Assert.Pass();
        }

        [Test]
        public void HighDailySwing_TestTrue()
        {
            // Arrange
            ICSVParser originalParser = new OriginalCSVParser();

            IFilterStrategy dailySwingReport = new HighDailySwing();
            StockMarket tradingDays = new StockMarket("test_original.csv", originalParser);

            // Set swing factor
            double swing_factor = 0.1;

            // Assert
            foreach (TradingDay day in tradingDays.GetTradingDays())
            {
                double swing = day.Open - day.Close;
                double percentageSwing = Math.Abs(swing / day.Open);

                if (percentageSwing > swing_factor)
                    Assert.IsTrue(dailySwingReport.Include(day, swing_factor));
            }
        }

        [Test]
        public void HighDailySwing_TestFalse()
        {
            // Arrange
            ICSVParser originalParser = new OriginalCSVParser();

            IFilterStrategy dailySwingReport = new HighDailySwing();
            StockMarket tradingDays = new StockMarket("test_original.csv", originalParser);

            // Set swing factor
            double swing_factor = 0.1;

            // Assert
            foreach (TradingDay day in tradingDays.GetTradingDays())
            {
                double swing = day.Open - day.Close;
                double percentageSwing = Math.Abs(swing / day.Open);

                if (percentageSwing <= swing_factor)
                    Assert.IsFalse(dailySwingReport.Include(day, swing_factor));
            }
        }
        [Test]
        public void HighDailyVolume_TestTrue()
        {
            // Arrange
            ICSVParser yahooParser = new YahooCSVParser();

            IFilterStrategy dailySwingReport = new HighDailyVolume();
            StockMarket tradingDays = new StockMarket("test_google.csv", yahooParser);

            // Set Volume Cap
            double dailyVolumeCap = 50000;

            // Assert
            foreach (TradingDay day in tradingDays.GetTradingDays())
            {
                double volume = day.Volume;

                if (volume > dailyVolumeCap)
                    Assert.IsTrue(dailySwingReport.Include(day, dailyVolumeCap));
            }
        }
        [Test]
        public void HighDailyVolume_TestFalse()
        {
            // Arrange
            ICSVParser yahooParser = new YahooCSVParser();

            IFilterStrategy dailySwingReport = new HighDailyVolume();
            StockMarket tradingDays = new StockMarket("test_google.csv", yahooParser);

            // Set Volume Cap
            double dailyVolumeCap = 50000;

            // Assert
            foreach (TradingDay day in tradingDays.GetTradingDays())
            {
                double volume = day.Volume;

                if (volume <= dailyVolumeCap)
                    Assert.IsFalse(dailySwingReport.Include(day, dailyVolumeCap));
            }
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SunriseSunsetLib;

namespace SunriseSunsetUnitTests
{
    [TestClass]
    public class SunriseSunsetTests
    {
        [TestMethod]
        public void InstantiateApi()
        {
            SunriseSunsetApi api_instance = new SunriseSunsetApi();

            SunriseSunsetResult data = api_instance.CallApi(45.3217219, -122.7686344, DateTime.Today);

            Assert.AreEqual($"{DateTime.Today} M/dd/yyyy H:mm:ss tt", Convert.ToString(data.results.sunrise));
            Assert.AreEqual("7/31/2020 8:38:50 PM", Convert.ToString(data.results.sunset));
        }
    }
}

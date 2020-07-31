using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunriseSunsetWPF;

namespace SunriseSunsetLib
{
    public class SunriseSunsetApi
    {
        private string address = $"https://api.sunrise-sunset.org/json?lat={0}&lng={1}&date={2}&formatted=0";

        public void CallApi(double longitude, double latitude, DateTime date)
        {

        }
    }
}

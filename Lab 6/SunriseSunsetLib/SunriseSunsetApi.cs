using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SunriseSunsetWPF;

namespace SunriseSunsetLib
{
    public class SunriseSunsetApi
    {
        private const string address = "https://api.sunrise-sunset.org/json?lat={0}&lng={1}&date={2}&formatted=0";

        public string CallApi(double longitude, double latitude, DateTime date)
        {
            string s = String.Format(address, longitude, latitude, date);

            using (WebClient client = new WebClient()) 
            {
                client.DownloadString(s);
            }

            return s;
        }
    }
}

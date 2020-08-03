using Newtonsoft.Json;
using System;
using System.Net;

namespace SunriseSunsetLib
{
    public class SunriseSunsetApi
    {
        private const string address = "https://api.sunrise-sunset.org/json?lat={0}&lng={1}&date={2}&formatted=0";

        public SunriseSunsetResult CallApi(double latitude, double longitude, DateTime date)
        {
            string formatted_data = String.Format("{0:yyyy-MM-dd}", date);
            string s = String.Format(address, latitude, longitude, formatted_data);

            using (WebClient client = new WebClient()) 
            {
                s = client.DownloadString(s);
            }

            if (s == null) return null;

            return JsonConvert.DeserializeObject<SunriseSunsetResult>(s);
            
        }
    }
}

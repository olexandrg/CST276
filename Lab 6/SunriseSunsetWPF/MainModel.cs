using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunriseSunsetLib;

namespace SunriseSunsetWPF
{
    public class MainModel
    {
        private SunriseSunsetApi api_instance;

        public MainModel()
        {
            this.api_instance = new SunriseSunsetApi();
        }

        public SunriseSunsetResult GetData(double longitude, double latitude, DateTime date)
        {
            return api_instance.CallApi(longitude, latitude, date);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockReportStrategies
{
    public class OriginalCSVParser : ICSVParser
    {
        void ICSVParser.Parse(string filename, List<TradingDay> list)
        {
            //the "using" statement will close the file automatically
            using (StreamReader reader = new StreamReader(filename))
            {
                // Skip header row
                reader.ReadLine();
                string dataRow = null;

                while ((dataRow = reader.ReadLine()) != null)
                {
                    DateTime Date;
                    double Open, High, Low, Close, Volume;

                    string[] vals = dataRow.Split(',');

                    Date = DateTime.Parse(vals[0]);
                    Open = double.Parse(vals[1]);
                    High = double.Parse(vals[2]);
                    Low = double.Parse(vals[3]);
                    Close = double.Parse(vals[4]);
                    Volume = double.Parse(vals[5]);

                    //Hack for two digit days in csv file..
                    if (Date > DateTime.Now)
                    {
                        Date = Date.AddYears(-100);
                    }

                    TradingDay day = new TradingDay(Date, Open, High, Low, Close, Volume);
                    list.Add(day);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SunriseSunsetLib;

namespace SunriseSunsetWPF
{
    public class MainVM : INotifyPropertyChanged
    {
        private MainModel model = new MainModel();
        public string Sunrise
        {
            get { return sunrise; }
            set { sunrise = value; NotifyPropertyChanged(); }
        }

        public string Sunset
        {
            get { return sunset; }
            set { sunset = value; NotifyPropertyChanged(); }
        }

        public string SolarNoon
        {
            get { return solar_noon; }
            set { solar_noon = value; NotifyPropertyChanged(); }
        }

        public string DayLength
        {
            get { return day_length; }
            set { day_length = value; NotifyPropertyChanged(); }
        }

        public string CivilTwilightStart
        {
            get { return civil_twilight_start; }
            set { civil_twilight_start = value; NotifyPropertyChanged(); }
        }

        public string CivilTwilightEnd
        {
            get { return civil_twilight_end; }
            set { civil_twilight_end = value; NotifyPropertyChanged(); }
        }

        public string NauticalTwilightStart
        {
            get { return nautical_twilight_start; }
            set { nautical_twilight_start = value; NotifyPropertyChanged(); }
        }

        public string NauticalTwilightEnd
        {
            get { return nautical_twilight_end; }
            set { nautical_twilight_end = value; NotifyPropertyChanged(); }
        }

        public string AstroTwilightStart
        {
            get { return astro_twilight_start; }
            set { astro_twilight_start = value; NotifyPropertyChanged(); }
        }

        public string AstroTwilightEnd
        {
            get { return astro_twilight_end; }
            set { astro_twilight_end = value; NotifyPropertyChanged(); }
        }
        public double Longitude { get => longitude; set => longitude = value; }
        public double Latitude { get => latitude; set => latitude = value; }
        public DateTime Date { get => date; set => date = value; }

        // API data
        private string sunrise;     
        private string sunset;
        private string solar_noon;
        private string day_length;
        private string civil_twilight_start;
        private string civil_twilight_end;
        private string nautical_twilight_start;
        private string nautical_twilight_end;
        private string astro_twilight_start;
        private string astro_twilight_end;

        // Hardcoded GPS values for Oregon Tech Wilsonville
        private double longitude;
        private double latitude;
        private DateTime date;

        public MainVM()
        {   
            this.Longitude = -122.7686344;
            this.Latitude = 45.3217219;
            this.Date = DateTime.Today;

            CalculateCommand = new Relay(() =>
            {
                SunriseSunsetResult data = model.GetData(latitude, longitude, date);
                this.Sunrise = DateFormatter(data.results.sunrise);
                this.Sunset = DateFormatter(data.results.sunset);
                this.SolarNoon = DateFormatter(data.results.solar_noon);
                this.DayLength = SecondsFormatter(data.results.day_length);
                this.CivilTwilightStart = DateFormatter(data.results.civil_twilight_begin);
                this.CivilTwilightEnd = DateFormatter(data.results.civil_twilight_end);
                this.NauticalTwilightStart = DateFormatter(data.results.nautical_twilight_begin);
                this.NauticalTwilightEnd = DateFormatter(data.results.nautical_twilight_end);
                this.AstroTwilightStart = DateFormatter(data.results.astronomical_twilight_begin);
                this.AstroTwilightEnd = DateFormatter(data.results.astronomical_twilight_end);
            });
        }

        private string DateFormatter(DateTime data)
        {
            return $"{data:hh:mm:ss tt}";
        }

        private string SecondsFormatter(int seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            return time.ToString(@"hh\:mm\:ss");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this,
            new PropertyChangedEventArgs(propertyname));
        }

        public ICommand CalculateCommand { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SunriseSunsetLib;

namespace SunriseSunsetWPF
{
    public class MainVM : INotifyPropertyChanged
    {
        public string Sunrise
        {
            get { return sunrise; }
            set { sunrise = value; NotifyPropertyChanged(); }
        }
        public double Longitude { get => longitude; set => longitude = value; }
        public double Latitude { get => latitude; set => latitude = value; }
        public DateTime Date { get => date; set => date = value; }

        private string sunrise;
        private double longitude;
        private double latitude;
        private DateTime date;

        public MainVM()
        {
            this.Longitude = -122.7686344;
            this.Latitude = 45.3217219;
            this.Date = DateTime.Today;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this,
            new PropertyChangedEventArgs(propertyname));
        }
    }
}

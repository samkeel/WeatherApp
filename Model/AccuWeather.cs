using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model
{
    //Values returned from JSON request
    //-------
    //public class Headline : INotifyPropertyChanged
    //{
    //    public DateTime EffectiveDate { get; set; }
    //    public int EffectiveEpochDate { get; set; }
    //    public int Severity { get; set; }
    //    public string Text { get; set; }
    //    public string Category { get; set; }
    //    public DateTime EndDate { get; set; }
    //    public int EndEpochDate { get; set; }
    //    public string MobileLink { get; set; }
    //    public string Link { get; set; }

    //    public event PropertyChangedEventHandler PropertyChanged;

    //    private void OnPropertyChanged(string propertyName)
    //    {
    //        if(PropertyChanged != null)
    //        {
    //            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    //        }
    //    }
    //}

    public class Minimum : INotifyPropertyChanged
    {
        private double valueProperty;
        public double Value
        {
            get { return valueProperty; }
            set
            {
                valueProperty = value;
                OnPropertyChanged("Value");
            }
        }
        private string unit;
        public string Unit {
            get { return unit; }
            set
            {
                unit = value;
                OnPropertyChanged("Unit");
            }
        }

        private int unitType;
        public int UnitType {
            get { return unitType; }
            set
            {
                unitType = value;
                OnPropertyChanged("UnitType");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class Maximum : INotifyPropertyChanged
    {
        private double valueProperty;
        public double Value
        {
            get { return valueProperty; }
            set
            {
                valueProperty = value;
                OnPropertyChanged("Value");
            }
        }
        private string unit;
        public string Unit
        {
            get { return unit; }
            set
            {
                unit = value;
                OnPropertyChanged("Unit");
            }
        }

        private int unitType;
        public int UnitType
        {
            get { return unitType; }
            set
            {
                unitType = value;
                OnPropertyChanged("UnitType");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class Temperature : INotifyPropertyChanged
    {
        private Minimum minimum;
        public Minimum Minimum
        {
            get { return minimum; }
            set
            {
                minimum = value;
                OnPropertyChanged("Minimum");
            }
        }

        private Maximum maximum;
        public Maximum Maximum
        {
            get { return maximum; }
            set
            {
                maximum = value;
                OnPropertyChanged("Maximum");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class Day : INotifyPropertyChanged
    {
        private int icon;
        public int Icon
        {
            get { return icon; }
            set
            {
                icon = value;
                OnPropertyChanged("Icon");
            }
        }

        private string iconPhrase;
        public string IconPhrase
        {
            get { return iconPhrase; }
            set
            {
                iconPhrase = value;
                OnPropertyChanged("IconPhrase");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class Night : INotifyPropertyChanged
    {

        private int icon;
        public int Icon
        {
            get { return icon; }
            set
            {
                icon = value;
                OnPropertyChanged("Icon");
            }
        }

        private string iconPhrase;
        public string IconPhrase
        {
            get { return iconPhrase; }
            set
            {
                iconPhrase = value;
                OnPropertyChanged("IconPhrase");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class DailyForecast : INotifyPropertyChanged
    {
        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }

        private int epochDate;
        public int EpochDate
        {
            get { return epochDate; }
            set
            {
                epochDate = value;
                OnPropertyChanged("EpochDate");
            }
        }
        private Temperature temperature;
        public Temperature Temperature
        {
            get { return temperature; }
            set
            {
                temperature = value;
                OnPropertyChanged("Temperature");
            }
        }
        private Day day;
        public Day Day
        {
            get { return day; }
            set
            {
                day = value;
                OnPropertyChanged("Day");
            }
        }
        private Night night;
        public Night Night
        {
            get { return night; }
            set
            {
                night = value;
                OnPropertyChanged("Night");
            }
        }
        private IList<string> sources;
        public IList<string> Sources
        {
            get { return sources; }
            set
            {
                sources = value;
                OnPropertyChanged("Sources");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class AccuWeather
    {
        public List<DailyForecast> DailyForecasts { get; set; }

        //public AccuWeather()
        //{
        //    DailyForecasts = new List<DailyForecast>();
        //    for (int i = 0; i < 3; i++)
        //    {
        //        DailyForecast dailyForecast = new DailyForecast
        //        {
        //            Date = DateTime.Now.AddDays(-i),
        //            Temperature = new Temperature
        //            {
        //                Maximum = new Maximum
        //                {
        //                    Value = 21 + i
        //                },
        //                Minimum = new Minimum
        //                {
        //                    Value = 5 - i
        //                }
        //            }
        //        };
        //        DailyForecasts.Add(dailyForecast);
        //    }
        //}


    }
}


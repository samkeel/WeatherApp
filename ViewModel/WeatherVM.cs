using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Model;
using WeatherApp.ViewModel.Commands;

namespace WeatherApp.ViewModel
{
    public class WeatherVM
    {
        public AccuWeather Weather { get; set; }

        private string query;
        public string Query
        {
            get { return query; }
            set
            {
                query = value;
                GetCities();
            }
        }

        public ObservableCollection<City> Cities { get; set; }
        public ObservableCollection<DailyForecast> Forecasts { get; set; }

        private City selectedResult;
        public City SelectedResult
        {
            get { return selectedResult; }
            set
            {
                selectedResult = value;
                GetWeather();
            }
        }

        public RefreshCommand RefreshCommand { get; set; }


        public WeatherVM()
        {
            Forecasts = new ObservableCollection<DailyForecast>();
            Cities = new ObservableCollection<City>();
            SelectedResult = new City();
            RefreshCommand = new RefreshCommand(this);
        }


        private async void GetCities()
        {
            var cities = await WeatherAPI.GetAutocompleteAsync(Query);

            Cities.Clear();
            foreach (var city in cities)
            {
                Cities.Add(city);
            }
        }

        public async void GetWeather()
        {
            //will initiate null - pending item selection
            var weather = await WeatherAPI.GetWeatherInformationAsync(SelectedResult.Key);
            if (weather.DailyForecasts != null) 
            {
                Forecasts.Clear();
                //loop through API received forcasts adding each to Forecast collection
                foreach (var forecast in weather.DailyForecasts)
                {
                    Forecasts.Add(forecast);
                }
            }
        }
    }
}

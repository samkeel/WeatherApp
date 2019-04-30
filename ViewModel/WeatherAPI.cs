using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Model;

namespace WeatherApp.ViewModel
{
    class WeatherAPI
    {
        public const string API_KEY = "7SdLIrsVYFeo7YSbtENe8PiZpGZPgAXT";
        public const string LOCATION = "16536";
        public const string BASE_URL = "http://dataservice.accuweather.com/forecasts/v1/daily/5day/{0}?apikey={1}%20&metric=true";
        public const string BASE_URL_AUTOCOMPLETE = "http://dataservice.accuweather.com/locations/v1/cities/autocomplete?apikey={0}&q={1}";

        public static async Task<AccuWeather> GetWeatherInformationAsync(string locationKey)
        {
            AccuWeather result = new AccuWeather();

            string url = string.Format(BASE_URL, locationKey, API_KEY);

            using (HttpClient client = new HttpClient())
            {
                var responce = await client.GetAsync(url);
                string json = await responce.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<AccuWeather>(json);
            }
                return result;
        }

        public static async Task<List<City>> GetAutocompleteAsync(string query)
        {
            List<City> result = new List<City>();

            string url = string.Format(BASE_URL_AUTOCOMPLETE, API_KEY, query);

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<List<City>>(json);
            }
            return result;
        }
    }
}

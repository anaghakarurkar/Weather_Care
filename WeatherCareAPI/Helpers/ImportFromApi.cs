using System;
using System.Net.Http;
using Newtonsoft.Json;
using WeatherCareAPI.Models.Json;

namespace WeatherCareAPI.Helpers
{
    public class ImportFromApi
    {
        public static async Task<ForecastDaily> ImportForecastDaily(string url)
        {
            //url = "https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&timezone=GMT&daily=weathercode,temperature_2m_max,temperature_2m_min,windspeed_10m_max,precipitation_sum";
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ForecastDaily>(responseBody);
            return result;
        }

        public static async Task<ForecastHourly> ImportForecastHourly(string url)
        {
            //url = "https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&hourly=temperature_2m,weathercode,relativehumidity_2m,windspeed_10m";
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ForecastHourly>(responseBody);
            return result ;
        }
    }
}

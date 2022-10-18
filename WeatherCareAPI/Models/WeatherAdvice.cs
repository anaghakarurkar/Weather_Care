using System;
using WeatherCareAPI.Models.Json;

namespace WeatherCareAPI.Models
{
    public class WeatherAdvice
    {
        // Weather Code Descripitons
        public Dictionary<int, string> weatherDescription = new Dictionary<int, string>
            {
                { 0, "Clear sky" },
                { 1, "Mainly clear" },
                { 2, "Partly cloudy" },
                { 3, "Overcast" },
                { 45, "Fog" },
                { 48, "Depositing rime fog" },
                { 51, "Drizzle: Light" },
                { 53, "Drizzle: Moderate" },
                { 55, "Drizzle: Dense intensity" },
                { 57, "Freezing Drizzle:: Dense intensity" },
                { 61, "Rain: Slight" },
                { 63, "Rain: Moderate" },
                { 65, "Rain: Heavy intensity" },
                { 66, "Freezing Rain: Light" },
                { 67, "Freezing Rain: Heavy intensity" },
                { 71, "Snow fall: Slight" },
                { 73, "Snow fall: Moderate" },
                { 75, "Snow fall: Heavy intensity" },
                { 77, "Snow grains" },
                { 80, "Rain showers: Slight" },
                { 81, "Rain showers: Moderate" },
                { 82, "Rain showers: Voilent" },
                { 85, "Snow showers: Slight" },
                { 86, "Snow showers: Heavy" },
                { 95, "Thunderstorm" },
                { 96, "Thunderstorm with slight hail" },
                { 99, "Thunderstorm with heavy hail" }
            };
        public WeatherAdvice()
        {
        }


        void WeatherCodeDescriptionDaily(ForecastDaily dailyForecast)
        {
            foreach (int x in dailyForecast.daily.weathercode)
            {
                Console.WriteLine("The Weather Description is :" + weatherDescription[x]);
            }
        }

        void WeatherCodeDescriptionHourly(ForecastHourly hourlyForecast)
        {

            foreach (int x in hourlyForecast.hourly.weathercode)
            {
                Console.WriteLine("The Weather Description is :" + weatherDescription[x]);

            }
        }

    }
}




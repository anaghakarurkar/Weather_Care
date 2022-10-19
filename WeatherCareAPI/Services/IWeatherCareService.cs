using System;
using WeatherCareAPI.Models;
using WeatherCareAPI.Models.Display;
using WeatherCareAPI.Models.Json;

namespace WeatherCareAPI.Services
{
    public interface IWeatherCareService
    {
        List<City> GetAllCities();
        Forecast GetLocationByCity(string cityName);
        DisplayClothingAdviceDaily GetClothingAdviceDaily(ForecastDaily forecastDaily);
        DisplayClothingAdviceHourly GetClothingAdviceHourly(ForecastHourly forecastHourly);
        public DisplayOneHour GetClothingAdviceCurrentHour(ForecastHourly forecastHourly);
    }
}
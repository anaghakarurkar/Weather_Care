using System;
using WeatherCareAPI.Models;
using WeatherCareAPI.Models.Json;

namespace WeatherCareAPI.Services
{
    public interface IWeatherForecastService
    {
        List<City> GetAllCities();
        Forecast GetLocationByCity(string cityName);
    }
}
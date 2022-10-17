using System;
using WeatherCareAPI.Models;

namespace WeatherCareAPI.Services
{
    public interface IWeatherForecastService
    {
        List<City> GetAllCities();
    }
}
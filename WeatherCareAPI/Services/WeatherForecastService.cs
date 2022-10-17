using WeatherCareAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Newtonsoft.Json;
using WeatherCareAPI.Models.Json;

namespace WeatherCareAPI.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly WeatherContext _context;

        public WeatherForecastService(WeatherContext context)
        {
            _context = context;
        }

        public List<City> GetAllCities()
        {
            var cities = _context.CityInfo.ToList();
            return cities;
        }

        public Forecast GetLocationByCity(string cityName)
        {
            Forecast location = new Forecast();
            var city = GetAllCities().Where(city => city.EnglishName.ToLower()==cityName.ToLower()).First();

            location.latitude = city.GeoPositionLatitude;
            location.longitude = city.GeoPositionLongitude;
            return location;
        }
    }
}
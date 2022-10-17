﻿using WeatherCareAPI.Models;
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

    }
}
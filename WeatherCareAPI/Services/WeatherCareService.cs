﻿using WeatherCareAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Newtonsoft.Json;
using WeatherCareAPI.Models.Json;
using WeatherCareAPI.Models.Display;

namespace WeatherCareAPI.Services
{
    public class WeatherCareService : IWeatherCareService
    {
        private readonly WeatherContext _context;

        public WeatherCareService(WeatherContext context)
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

        public DisplayClothingAdviceDaily GetClothingAdviceDaily (ForecastDaily forecastDaily)
        {
            var displayClothingAdviceDaily = new DisplayClothingAdviceDaily();
            for (int i = 0; i < forecastDaily.daily.time.Length; i++)
            {
                var weatherAdvice = new WeatherAdvice();
                var clothingAdvice = new ClothingAdvice();
                clothingAdvice.SetDailyClothingType(forecastDaily);
                var oneDay = new DisplayOneDay(
                    forecastDaily.daily.time[i],
                    (forecastDaily.daily.temperature_2m_max[i] + forecastDaily.daily.temperature_2m_min[i]) / 2,
                    weatherAdvice.weatherDescription[forecastDaily.daily.weathercode[i]],
                    clothingAdvice.GetClothingBasedOnType(clothingAdvice.dailyClothingType)[i]
                    );
                ; 
                displayClothingAdviceDaily.DisplayOneDayList.Add(oneDay);
            }
            return displayClothingAdviceDaily;          
        }


    }
}
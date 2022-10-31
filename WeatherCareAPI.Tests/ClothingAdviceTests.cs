using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using WeatherCareAPI.Models;
using WeatherCareAPI.Helpers;
using WeatherCareAPI.Models.Json;
using System.Reflection;
//using WeatherCareAPI.Services;

namespace WeatherCareAPI.Tests

{
    [TestClass]

    public class ClothingAdviceTests
    {
        private DateTime currentDate;
        private ClothingAdvice _clothingadvice;
       


        [SetUp]
        public void Setup()
        {
    
            _clothingadvice = new ClothingAdvice();
            currentDate = DateTime.Now.Date;

        }

       

        [TestCase("https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&timezone=GMT&daily=weathercode,temperature_2m_max,temperature_2m_min,windspeed_10m_max,precipitation_sum", 52.52)]

        public void ClothingTypeShouldBeSetAccordingtoTemp2mMax(string url, double lat)
        {

          var forecast = ImportFromApi.ImportForecastDaily(url).GetAwaiter().GetResult();
            string temp = "";
            if ((forecast.daily.temperature_2m_max[0] + forecast.daily.temperature_2m_min[0]) / 2 > 20)
            { temp = "Hot"; }
            else if ((forecast.daily.temperature_2m_max[0] + forecast.daily.temperature_2m_min[0]) / 2 > 10)
                temp = "Mild";
            else temp = "Cold";
            _clothingadvice.SetDailyClothingType(forecast);
           
            _clothingadvice.dailyClothingType[0].Should().Be(temp);
        }
        
        [TestCase("https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&timezone=GMT&daily=weathercode,temperature_2m_max,temperature_2m_min,windspeed_10m_max,precipitation_sum", 52.52)]
        public void ClothingSuggestionsSetAccordingtoClothingTypeDaily(string url, double lat)
        {
        var forecast = ImportFromApi.ImportForecastDaily(url).GetAwaiter().GetResult();
            forecast.latitude = 52.52;
            forecast.longitude = 13.419998;
            // psudo temp values 
            forecast.daily.temperature_2m_max = new float[] { 17, 17, 14, 14, 12, 11, 11 };
            forecast.daily.temperature_2m_min = new float[] { 10, 10, 10, 9, 1, 11, 11 };
            forecast.daily.weathercode = new int[] { 45, 61, 3, 3, 61, 3, 61 };
            _clothingadvice.SetDailyClothingType(forecast);
            List<List<string>> x = _clothingadvice.GetClothingBasedOnType(_clothingadvice.dailyClothingType);
       x[0][0].Should().Be("Jumper");
            
        }
      [TestCase("https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&hourly=temperature_2m,weathercode,relativehumidity_2m,windspeed_10m", 52.52)]

       public void ClothingSuggestionsSetAccordingtoClothingTypeHourly(string url, double lat)
        {
        var forecast = ImportFromApi.ImportForecastHourly(url).GetAwaiter().GetResult();

            // psudo temp values 
            forecast.hourly.weathercode = new int[] { 3, 0, 0, 45, 1, 0, 3, 45, 3, 1, 1, 1, 2, 3, 3, 3, 45, 45, 45, 3, 3, 3, 3, 3, 3, 3, 2, 2, 3, 3, 3, 3, 3, 3, 61, 3, 3, 2, 3, 3, 2, 3, 3, 3, 3, 2, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 1, 2, 0, 1, 3, 2, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 3, 2, 3, 3, 3, 3, 3, 3, 2, 3, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 61, 61, 61, 3, 3, 3, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 1, 1, 2, 2, 2, 2, 2, 2, 3, 3, 3, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 61, 61, 61, 61, 61 };
            forecast.hourly.temperature_2m = new float[]
            {10, 10, 10, 10, 10, 9, 9, 10, 11, 12, 14, 15, 16, 17, 17, 16, 14, 13, 13, 13, 13, 12, 12, 12,
            10, 10, 10, 10, 10, 9, 9, 10, 11, 12, 14, 15, 16, 17, 17, 16, 14, 13, 13, 13, 13, 12, 12, 12,
            10, 10, 10, 10, 10, 9, 9, 10, 11, 12, 14, 15, 16, 17, 17, 16, 14, 13, 13, 13, 13, 12, 12, 12,
            10, 10, 10, 10, 10, 9, 9, 10, 11, 12, 14, 15, 16, 17, 17, 16, 14, 13, 13, 13, 13, 12, 12, 12,
            10, 10, 10, 10, 10, 9, 9, 10, 11, 12, 14, 15, 16, 17, 17, 16, 14, 13, 13, 13, 13, 12, 12, 12,
            10, 10, 10, 10, 10, 9, 9, 10, 11, 12, 14, 15, 16, 17, 17, 16, 14, 13, 13, 13, 13, 12, 12, 12,
            10, 10, 10, 10, 10, 9, 9, 10, 11, 12, 14, 15, 16, 17, 17, 16, 14, 13, 13, 13, 13, 12, 12, 12, };
         _clothingadvice.SetHourlyClothingType(forecast);
         List<List<string>> x = _clothingadvice.GetClothingBasedOnType(_clothingadvice.hourlyClothingType);
        x[0][0].Should().Be("Beanie");
       }
        

    }
}


using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using WeatherCareAPI.Models;
using WeatherCareAPI.Helpers;
using WeatherCareAPI.Models.Json;
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
            _clothingadvice.SetDailyClothingType(forecast);
            _clothingadvice.dailyClothingType[0].Should().Be("Hot");
        }
        [TestCase("https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&timezone=GMT&daily=weathercode,temperature_2m_max,temperature_2m_min,windspeed_10m_max,precipitation_sum", 52.52)]
        public void ClothingSuggestionsSetAccordingtoClothingType(string url, double lat)
        {
            var forecast = ImportFromApi.ImportForecastDaily(url).GetAwaiter().GetResult();
            _clothingadvice.SetDailyClothingType(forecast);
            List<Clothing> x = _clothingadvice.DailyGetClothingBasedOnType(_clothingadvice.dailyClothingType);
            foreach(Clothing i in x)
            {
                Console.WriteLine(i.clothingDescription);
            }
        }


    }
}


using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using WeatherCareAPI.Helpers;
namespace WeatherCareAPI.Tests
{
    [TestClass]

    public class ExternalApiTests
    {

        [TestCase("https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&hourly=temperature_2m,weathercode,relativehumidity_2m,windspeed_10m", 52.52)]
        [TestCase("https://api.open-meteo.com/v1/forecast?latitude=56.95&longitude=24.11&hourly=temperature_2m,weathercode,relativehumidity_2m,windspeed_10m", 56.9375)]

        public void TestImportFromApiHourlyLatitude(string url, double lat)
        {
            var forecast = ImportFromApi.ImportForecastHourly(url).GetAwaiter().GetResult();
            forecast.latitude.Should().Be(lat); 
        }

        [TestCase("https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&timezone=GMT&daily=weathercode,temperature_2m_max,temperature_2m_min,windspeed_10m_max,precipitation_sum", 52.52)]
        [TestCase("https://api.open-meteo.com/v1/forecast?latitude=56.95&longitude=24.11&hourly=temperature_2m,weathercode,relativehumidity_2m,windspeed_10m", 56.9375)]

        public void TestImportFromApiDailyLatitude(string url, double lat)
        {
            var forecast = ImportFromApi.ImportForecastDaily(url).GetAwaiter().GetResult();
            forecast.latitude.Should().Be(lat);
        }


    }
}


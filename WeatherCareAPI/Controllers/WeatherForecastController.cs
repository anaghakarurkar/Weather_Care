using Microsoft.AspNetCore.Mvc;
using WeatherCareAPI.Models;
using WeatherCareAPI.Services;
using WeatherCareAPI.Models.Json;
using WeatherCareAPI.Helpers;

namespace WeatherCareAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        //  /WeatherForecast/daily/Mumbai
        [HttpGet("daily/{cityName}")]
        public ActionResult<IEnumerable<ForecastDaily>> GetDailyForecastByCity(string cityName)
        {
            Forecast location = _weatherForecastService.GetLocationByCity(cityName);
            var foreCastDaily = ImportFromApi.ImportForecastDaily($"https://api.open-meteo.com/v1/forecast?latitude={location.latitude}&longitude={location.longitude}&timezone=GMT&daily=weathercode,temperature_2m_max,temperature_2m_min,windspeed_10m_max,precipitation_sum").GetAwaiter().GetResult();
            return Ok(foreCastDaily);
        }

        //  /WeatherForecast/hourly/{cityName}
        [HttpGet("hourly/{cityName}")]
        public ActionResult<IEnumerable<ForecastHourly>> GetHourlyForecastByCity(string cityName)
        {
            Forecast location = _weatherForecastService.GetLocationByCity(cityName);
            var foreCastHourly = ImportFromApi.ImportForecastHourly($"https://api.open-meteo.com/v1/forecast?latitude={location.latitude}&longitude={location.longitude}&hourly=temperature_2m,weathercode,relativehumidity_2m,windspeed_10m").GetAwaiter().GetResult();
            return Ok(foreCastHourly);
        }

        //  /WeatherForecast/geolocation?latitude=52.52&longitude=14.43
        [HttpGet("geolocation")]
        public ActionResult<IEnumerable<DisplayClothingAdvice>> SuggestClothingUsingGeoLocation(double latitude, double longitude)
        {
            return Ok(new DisplayClothingAdvice());
        }







        [HttpGet("DB")]
        public ActionResult<IEnumerable<City>> GetCities()
        {
            return _weatherForecastService.GetAllCities();
        }
    }
}
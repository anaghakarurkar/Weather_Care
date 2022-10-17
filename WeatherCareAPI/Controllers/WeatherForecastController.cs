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

        [HttpGet("/Daily/{cityName}")]
        public ActionResult<IEnumerable<ForecastDaily>> GetDailyForecastByCity(string cityName)
        {
            var foreCastDaily = ImportFromApi.ImportForecastDaily("https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&timezone=GMT&daily=weathercode,temperature_2m_max,temperature_2m_min,windspeed_10m_max,precipitation_sum").GetAwaiter().GetResult();
            return Ok(foreCastDaily);
        }



        [HttpGet("DB")]
        public ActionResult<IEnumerable<City>> GetCities()
        {
            return _weatherForecastService.GetAllCities();
        }
    }
}
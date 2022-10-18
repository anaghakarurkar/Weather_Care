using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherCareAPI.Services;
using Moq;
using WeatherCareAPI.Controllers;
using Microsoft.Extensions.Logging;
using WeatherCareAPI.Models;
using Microsoft.EntityFrameworkCore;
using WeatherCareAPI.Models.Json;
using Microsoft.AspNetCore.Mvc;
using WeatherCareAPI.Models.Display;
using FluentAssertions;
using NUnit;

namespace WeatherCareAPI.Tests;

public class WeatherCareControllerTests
{
    private WeatherCareController _controller;
    private Mock<IWeatherCareService> _mockWeatherCareService;
    private Mock<ILogger<WeatherCareController>> _mockLogger;
    private ILoggerFactory _mockLoggerFactory;

    private static DbContextOptions<WeatherContext> dbContextOptions = new DbContextOptionsBuilder<WeatherContext>()
          .UseInMemoryDatabase(databaseName: "WeatherCareDB")
          .Options;
    WeatherContext context;

    [SetUp]
    public void Setup()
    {
        //Arrange
        _mockWeatherCareService = new Mock<IWeatherCareService>();
        
        _controller = new WeatherCareController(_mockLogger.Object, _mockWeatherCareService.Object);
        Console.WriteLine(_controller.ToString());
       
        _mockLogger = (Mock<ILogger<WeatherCareController>>)(ILogger) new Logger<WeatherCareController>(_mockLoggerFactory) ;
        Console.WriteLine(_mockLogger.ToString());
       
        
        context = new WeatherContext(dbContextOptions);
       var result =  context.Database.EnsureCreated();
        Console.WriteLine(result);
        SeedDatabase();

    }

    [Test]
    public void GetDailyAdviceByCity_Should_Return_Clothing_Advice_Using_City()
    {
        ////Arange
        //Forecast location = new Forecast();
        //location.latitude = 23.71;
        //location.longitude = 90.407;
        string cityName = "Dhaka";

        //Arrange
      // _mockWeatherCareService.Setup(b => b.GetLocationByCity(cityName)).Returns(location);
       
        //Act
        var result = _controller.GetDailyAdviceByCity(cityName);

        //Assert

        result.Should().BeOfType(typeof(ActionResult<IEnumerable<DisplayClothingAdviceDaily>>));
        //result.Value.Should().BeEquivalentTo(GetTestBooks());
        //result.Value.Count().Should().Be(3);
    }


    //[OneTimeTearDown]
    //public void CleanUp()
    //{
    //    context.Database.EnsureDeleted();
    //}



    private void SeedDatabase()
    {
        var cities = new List<City>()
        {
            new City()
            {
                Id = 28143,
                EnglishName ="Dhaka",
                TimeZoneCode = "BDT",
                GeoPositionLatitude = 23.71f,
                GeoPositionLongitude =  90.407f
            },
            new City()
            {
                Id = 113487,
                EnglishName ="Kinshasa",
                TimeZoneCode = "WAT",
                GeoPositionLatitude = -4.316f,
                GeoPositionLongitude =  15.298f
            }
        };

        context.CityInfo.AddRange(cities);
        context.SaveChanges();

        Console.WriteLine(context.CityInfo.Count());
    }
}





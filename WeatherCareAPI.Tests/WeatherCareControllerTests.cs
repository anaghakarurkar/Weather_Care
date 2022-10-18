using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherCareAPI.Services;
using Moq;
using WeatherCareAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace WeatherCareAPI.Tests;

public class WeatherCareControllerTests
{
    private WeatherCareController _controller;
    private Mock<IWeatherCareService> _mockWeatherCareService;
    private Mock<ILogger<WeatherCareController>> _mockLogger;

    [SetUp]
    public void Setup()
    {
        //Arrange
        _mockWeatherCareService = new Mock<IWeatherCareService>();
        _controller = new WeatherCareController(_mockLogger.Object, _mockWeatherCareService.Object);
    }

    [Test]
    public void GetDailyAdviceByCity_Should_Return_Clothing_Advice_Using_City()
    {
        ////Arange
        //_mockWeatherCareService.Setup(b => b.GetAllBooks()).Returns(GetTestBooks());

        ////Act
        //var result = _controller.GetBooks();

        ////Assert
        //result.Should().BeOfType(typeof(ActionResult<IEnumerable<Book>>));
        //result.Value.Should().BeEquivalentTo(GetTestBooks());
        //result.Value.Count().Should().Be(3);
    }


}


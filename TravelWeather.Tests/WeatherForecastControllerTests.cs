using Microsoft.Extensions.Logging;
using Moq;
using TravelWeather.Controllers;

namespace TravelWeather.Tests;

public class WeatherForecastControllerTests
{
    [Fact]
    public void GetCountries_ReturnsListOfCountries()
    {
        // Arrange
        var logger = new Mock<ILogger<WeatherForecastController>>();
        var controller = new WeatherForecastController(logger.Object);

        // Act
        var result = controller.GetCountries();

        // Assert
        var expectedCountries = new List<string> { "England", "France", "Germany", "Peru", "Portugal", "Italy", "Spain" };
        Assert.Equal(expectedCountries, result.ToList());
    }
}

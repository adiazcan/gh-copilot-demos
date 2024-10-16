using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace TravelWeather.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly JsonDocument weatherData;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
        weatherData = JsonDocument.Parse(System.IO.File.ReadAllText("weather.json"));
    }

    [HttpGet("countries")]
    public IEnumerable<string> GetCountries()
    {
        return weatherData.RootElement.EnumerateObject().Select(country => country.Name);
    }
}


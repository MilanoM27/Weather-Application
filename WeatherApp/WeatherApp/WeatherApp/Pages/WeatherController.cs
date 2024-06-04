using Microsoft.AspNetCore.Mvc;

public class WeatherController : Controller
{
    private readonly WeatherService _weatherService;

    public WeatherController(WeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    [HttpGet]
    public async Task<IActionResult> Index(string location = "Pretoria")
    {
        if (string.IsNullOrEmpty(location))
        {
            return BadRequest("Location is required.");
        }

        try
        {
            var weatherData = await _weatherService.GetWeather(location);
            return View(weatherData);
        }
        catch (Exception ex)
        {
            return View("Error", new ErrorViewModel { Message = ex.Message }); // Handle errors  (optional)
        }
    }
}

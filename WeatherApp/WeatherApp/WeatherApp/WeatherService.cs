using Newtonsoft.Json;

public class WeatherService
{
    private readonly string _apiKey;
    private readonly HttpClient _httpClient;

    public WeatherService(string 5fdcbc992dd34e7db0693056240406)
    {
        _apiKey = 5fdcbc992dd34e7db0693056240406;
        _httpClient = new HttpClient();
    }

    public async Task<WeatherData> GetWeather(string location)
    {
        var baseUrl = $"https://api.weatherapi.com/v1/current.json?key={5fdcbc992dd34e7db0693056240406}&q={location}";
        var response = await _httpClient.GetAsync(baseUrl);

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<WeatherData>(content);
        }
        else
        {
            throw new Exception($"Error fetching weather data: {response.StatusCode}");
        }
    }
}

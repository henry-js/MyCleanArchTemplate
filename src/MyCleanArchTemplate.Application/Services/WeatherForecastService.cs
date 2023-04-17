using MyCleanArchTemplate.Core;

namespace MyCleanArchTemplate.Application.Services;

public class WeatherForecastService : IWeatherForecastService
{
    private readonly IWeatherForecastRepository _repo;

    public WeatherForecastService(IWeatherForecastRepository repo)
    {
        _repo = repo;
    }

    public List<WeatherForecast> ProcessFTemperature()
    {
        var forecasts = _repo.GetForecasts();
        var processed = new List<WeatherForecast>();
        foreach (var f in forecasts)
        {
            f.TemperatureF = f.TemperatureC * 9 / 5 + 32;
            processed.Add(f);
        }
        return processed;
    }
}

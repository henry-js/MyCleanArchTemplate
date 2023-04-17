using MyCleanArchTemplate.Application;
using MyCleanArchTemplate.Core;

namespace MyCleanArchTemplate.Infrastructure;

public class WeatherForecastRepository : IWeatherForecastRepository
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing" ,"Bracing " ,"Chitty" ,"Coot","Mild","Warm","Balmy" ,"Hot","Sweltering" ,"Scorching",
    };
    public WeatherForecast[] GetForecasts()
    {
        var rng = new Random();
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = rng.Next(-20, 55),
            Summary = Summaries[rng.Next(Summaries.Length)]
        }).ToArray();

    }
}

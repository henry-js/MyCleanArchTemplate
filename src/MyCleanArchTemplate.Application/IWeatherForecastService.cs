using MyCleanArchTemplate.Core;

namespace MyCleanArchTemplate.Application;

public interface IWeatherForecastService
{
    List<WeatherForecast> ProcessFTemperature();
}

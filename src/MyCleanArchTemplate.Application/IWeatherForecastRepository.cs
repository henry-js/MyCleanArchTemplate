using MyCleanArchTemplate.Core;

namespace MyCleanArchTemplate.Application;

public interface IWeatherForecastRepository
{
    WeatherForecast[] GetForecasts();
}

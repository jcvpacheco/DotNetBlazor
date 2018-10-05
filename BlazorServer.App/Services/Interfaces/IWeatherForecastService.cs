using System;
using System.Threading.Tasks;

namespace BlazorServer.App.Services.Interfaces
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
    }
}
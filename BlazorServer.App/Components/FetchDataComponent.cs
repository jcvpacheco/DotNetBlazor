using BlazorServer.App.Services;
using BlazorServer.App.Services.Interfaces;
using Microsoft.AspNetCore.Blazor.Components;
using System;
using System.Threading.Tasks;

namespace BlazorServer.App.Components
{
    public class FetchDataComponent : BlazorComponent
    {
        public WeatherForecast[] Forecasts { get; set; }

        [Inject]
        public IWeatherForecastService forecastService { get; set; }

        protected override async Task OnInitAsync()
        {
            Forecasts = await GetForecastAsync(DateTime.Now);
        }

        public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            return await forecastService.GetForecastAsync(startDate);
        }
    }
}

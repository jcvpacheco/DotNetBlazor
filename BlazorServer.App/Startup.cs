using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;
using BlazorServer.App.Services;
using BlazorServer.App.Pages;
using BlazorServer.App.Services.Interfaces;

namespace BlazorServer.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Since Blazor is running on the server, we can use an application service
            // to read the forecast data.
            //services.AddSingleton<WeatherForecastService>();

            services.AddSingleton<IWeatherForecastService, WeatherForecastService>();
            //services.AddScoped<IWeatherForecastService, WeatherForecastService>();
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}

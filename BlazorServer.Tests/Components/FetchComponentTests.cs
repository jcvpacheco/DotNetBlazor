using BlazorServer.App.Components;
using BlazorServer.App.Services;
using BlazorServer.App.Services.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Threading.Tasks;

namespace BlazorServer.Tests.Components
{
    [TestClass]
    public class FetchComponentTests
    {
        [TestMethod]
        public async Task GetForecastAsync_Invoke_GetForecastAsyncFromIWeatherForecastServiceWasCalled()
        {
            var weatherForecastServiceMock = new Mock<IWeatherForecastService>();
            weatherForecastServiceMock.Setup(weatherForecastService => weatherForecastService.GetForecastAsync(It.IsAny<DateTime>()))
                .ReturnsAsync(new WeatherForecast[0]);

            var someClass = new FetchDataComponent { forecastService = weatherForecastServiceMock.Object };
            await someClass.GetForecastAsync(It.IsAny<DateTime>());

            weatherForecastServiceMock.Verify(foo => foo.GetForecastAsync(It.IsAny<DateTime>()), Times.AtLeastOnce());
        }
    }
}

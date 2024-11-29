using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aIQ.Core.FunctionalTests.Features.WeatherForecasts.Queries.GetWeatherForecasts;

[Collection("Context collection")]
public  class GetWeatherForecastsTests
{
    [Fact]
    public void Test1()
    {
        // Arrange

        int x = 1;

        // Act
        int y = 2;

        // Assert
        Assert.Equal(3, x + y);
    }
}

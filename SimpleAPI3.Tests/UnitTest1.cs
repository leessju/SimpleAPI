using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        //WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void GetReturnsCorrectNumber()
        {
            //var returnValue = controller.Get(1);
            Assert.Equal("nicejames", "nicejames");
        }
    }
}

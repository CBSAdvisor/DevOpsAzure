using System;
using WeatherApi.Controllers;
using Xunit;

namespace WeatherApi.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnsCorrectNumber()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("asd", returnValue.Value);
        }
    }
}

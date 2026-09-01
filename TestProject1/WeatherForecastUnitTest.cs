using Clean.API.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace TestProject1
{
    public class WeatherForecastUnitTest
    {
        [Fact]
        public void Div_divByZero()
        {
            //AAA
            //Arrange
            int a = 90;
            int b = 0;

            //Act
            WeatherForecastController controller = new WeatherForecastController();
            // Act
            var result = controller.Div(a, b);

            // Assert
            var badRequest = Assert.IsType<BadRequestObjectResult>(result.Result);
            Assert.Equal("Cannot divide by zero", badRequest.Value);
        }
    }
}
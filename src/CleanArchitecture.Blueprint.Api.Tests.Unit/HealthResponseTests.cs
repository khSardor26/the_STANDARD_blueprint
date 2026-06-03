using CleanArchitecture.Blueprint.Api.Controllers;

namespace CleanArchitecture.Blueprint.Api.Tests.Unit
{
    public class HealthResponseTests
    {
        [Fact]
        public void ShouldCreateHealthResponse()
        {
            var response = new HealthResponse
            {
                Status = "Healthy"
            };

            Assert.Equal("Healthy", response.Status);
        }
    }
}

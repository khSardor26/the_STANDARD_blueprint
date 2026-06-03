using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Threading.Tasks;

namespace CleanArchitecture.Blueprint.Api.Tests.Acceptance
{
    public class HealthEndpointTests
    {
        [Fact]
        public async Task ShouldReturnHealthyStatus()
        {
            await using WebApplicationFactory<Program> factory =
                new WebApplicationFactory<Program>();

            var client = factory.CreateClient();

            var response = await client.GetAsync("/health");
            var content = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Contains("Healthy", content);
        }
    }
}

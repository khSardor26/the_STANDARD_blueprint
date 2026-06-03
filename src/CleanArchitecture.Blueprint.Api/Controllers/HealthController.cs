using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Blueprint.Api.Controllers
{
    [ApiController]
    [Route("health")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() =>
            this.Ok(new HealthResponse { Status = "Healthy" });
    }
}

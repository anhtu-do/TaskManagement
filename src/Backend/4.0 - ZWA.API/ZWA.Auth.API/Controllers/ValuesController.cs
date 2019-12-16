using Microsoft.AspNetCore.Mvc;

namespace ZWA.Auth.API.Controllers
{
    [Route("api/auth-values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("get-values")]
        public IActionResult Get()
        {
            return Ok(new[] { "V1, V2, V3" });
        }
    }
}

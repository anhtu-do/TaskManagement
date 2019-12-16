using Microsoft.AspNetCore.Mvc;

namespace ZWA.TaskManagement.API.Controllers
{
    [Route("api/task-values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("get-values")]
        public IActionResult Get()
        {
            return Ok(new[] { "V4, V5, V6" });
        }
    }
}

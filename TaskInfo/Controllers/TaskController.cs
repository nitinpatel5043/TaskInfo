
using Microsoft.AspNetCore.Mvc;

namespace TaskInfo.Controllers
{
    [Route("task")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Task")]
    public class TaskController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("This is the Task root. Use the Swagger UI to explore sub-resources.");
        }
    }
}

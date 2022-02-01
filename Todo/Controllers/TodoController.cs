using Microsoft.AspNetCore.Mvc;

namespace Todo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        public IActionResult TestRun()
        {
            return Ok("succes");
        }
        
    }
}
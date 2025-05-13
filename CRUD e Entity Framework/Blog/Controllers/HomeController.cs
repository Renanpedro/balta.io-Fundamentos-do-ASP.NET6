using Microsoft.AspNetCore.Mvc;

// Health Check - Checagem de saude é um metodo para mostrar se api está ativa ou não
namespace Blog.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}

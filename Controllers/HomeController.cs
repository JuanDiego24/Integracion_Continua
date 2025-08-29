using Microsoft.AspNetCore.Mvc;

namespace TuProyecto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet("mensaje")]
        public IActionResult GetMensaje()
        {

            return Ok("Nuevo mensaje desde la corrección");

        }
    }
}

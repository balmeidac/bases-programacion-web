using Microsoft.AspNetCore.Mvc;

namespace HolaMundoAPI.Controllers;

[ApiController]
[Route("api/hola")]
public class HolaController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            mensaje = "Hola Mundo",
            lenguaje = "C#",
            framework = "ASP.NET Core Web API"
        });
    }
}
using Microsoft.AspNetCore.Mvc;

namespace HolaMundoAPI.Controllers;

[ApiController]
[Route("api")]
public class HolaController : ControllerBase
{
    // Endpoint 1: GET /api/hola
    [HttpGet("hola")]
    public IActionResult Get()
    {
        return Ok(new
        {
            mensaje = "Hola Mundo",
            lenguaje = "C#",
            framework = "ASP.NET Core Web API"
        });
    }

    // Endpoint 2: GET /api/saludo/{nombre}
    [HttpGet("saludo/{nombre}")]
    public IActionResult Saludo(string nombre)
    {
        return Ok(new
        {
            mensaje = $"Hola {nombre}"
        });
    }
}
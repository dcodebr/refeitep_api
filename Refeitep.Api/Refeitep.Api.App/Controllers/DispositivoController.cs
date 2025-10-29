using Microsoft.AspNetCore.Mvc;

namespace Refeitep.Api.App.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DispositivoController : ControllerBase
{

    //http://localhost:8000/api/dispositivo/ POST
    [HttpPost]
    public async Task<IActionResult> Autenticar()
    {
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> Sair()
    {
        return Ok();
    }
}

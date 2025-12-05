using Microsoft.AspNetCore.Mvc;

namespace Refeitep.Api.App.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ProdutoController : Controller
{
    [HttpGet]

    public async Task<IActionResult> Get()
    {
        return Ok();
    }

    [HttpGet("{id}")]

    public async Task<IActionResult> GetById(int id)
    {
        return Ok();
    }

    [HttpPost]

    public async Task<IActionResult> Post()
    {
        return Ok();
    }

    [HttpPut("{id}")]

    public async Task<IActionResult> Put(int id)
    {
        return Ok();
    }

    [HttpDelete("{id}")]

    public async Task<IActionResult> Delete(int id)
    {
        return Ok();
    }

}

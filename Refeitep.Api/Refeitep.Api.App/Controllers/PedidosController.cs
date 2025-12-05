using Microsoft.AspNetCore.Mvc;
using Refeitep.Api.Models;
using Refeitep.Api.Service.Pedido;

namespace Refeitep.Api.App.Controllers;

[ApiController]
[Route("api/[controller]")]

public class PedidosController : Controller
{
    private PedidoService PedidoService = new PedidoService();

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await PedidoService.Consultar());
    }

    [HttpGet("{id}")]

    public async Task<IActionResult> GetById(int id)
    {
        return Ok(await PedidoService.ConsultarId(id));
    }

    [HttpGet("/disp/{id}")]

    public async Task<IActionResult> GetByDisp(int id)
    {
        return Ok(await PedidoService.RetornarPorDispositivo(id));
    }

    [HttpGet("/cliente/{id}")]

    public async Task<IActionResult> GetByCliente(int id)
    {
        return Ok(await PedidoService.RetornarPorCliente(id));
    }

    [HttpPost]

    public async Task<IActionResult> Post(Pedido pedido)
    {
        return Ok(await PedidoService.Adicionar(pedido));
    }


    [HttpPut("{id}")]

    public async Task<IActionResult> Put(int id, Pedido pedido)
    {
        return Ok(await PedidoService.Alterar(id, pedido));

    }

    [HttpDelete("{id}")]

    public async Task<IActionResult> Delete(int id)
    {
        await PedidoService.Remover(id);
        return Ok();
    }
}

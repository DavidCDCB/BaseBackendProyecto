using RestServer.DTOs;
using Microsoft.AspNetCore.Mvc;
using RestServer.Interfaces;
using Domain.Entities;

namespace RestServer.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ClientController : Controller
  {
    private readonly IClientRepository ClientRepository;

    public ClientController(IClientRepository ClientRepository)
    {
      this.ClientRepository = ClientRepository;
    }

    [HttpGet]
    public async Task<ActionResult> GetClients()
    {
      return Ok(await this.ClientRepository.GetClients());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetClient(int id)
    {
      Client? encontrado = await this.ClientRepository.GetClient(id);

      if (encontrado == null)
      {
        return NotFound();
      }

      return Ok(encontrado);
    }

    [HttpPost]
    public async Task<IActionResult> PostClient(ClientDTO ClientDTO)
    {
      try
      {
        return Ok(await this.ClientRepository.PostClient(ClientDTO));
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        return BadRequest(e);
      }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutClient(int id, ClientDTO ClientDTO)
    {
      Client? actualizado = await this.ClientRepository.UpdateClient(id, ClientDTO);

      if (actualizado == null)
      {
        return NotFound();
      }
      return Ok(actualizado);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveClient(int id)
    {
      Client? eliminado = await this.ClientRepository.DeleteClient(id);

      if (eliminado == null)
      {
        return NotFound();
      }
      return Ok(eliminado);

    }
  }
}

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
    private readonly IClientRepository clientRepository;

    public ClientController(IClientRepository clientRepository)
    {
      this.clientRepository = clientRepository;
    }

    [HttpGet]
    public async Task<ActionResult> GetClients()
    {
      return Ok(await this.clientRepository.GetClients());
    }

    [HttpGet("page/{num}")]
    public async Task<ActionResult> GetSuppliersByPage(int num)
    {
      List<Client> clients = await this.clientRepository.GetByPage(num);
      return clients.Count > 0 ? Ok(clients) : NoContent();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetClient(int id)
    {
      Client? encontrado = await this.clientRepository.GetClient(id);

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
        return Ok(await this.clientRepository.PostClient(ClientDTO));
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
      Client? actualizado = await this.clientRepository.UpdateClient(id, ClientDTO);

      if (actualizado == null)
      {
        return NotFound();
      }
      return Ok(actualizado);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveClient(int id)
    {
      Client? eliminado = await this.clientRepository.DeleteClient(id);

      if (eliminado == null)
      {
        return NotFound();
      }
      return Ok(eliminado);

    }
  }
}

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
      Client? find = await this.clientRepository.GetClient(id);

      if (find == null)
      {
        return NotFound();
      }

      return Ok(find);
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
      Client? updated = await this.clientRepository.UpdateClient(id, ClientDTO);

      if (updated == null)
      {
        return NotFound();
      }
      return Ok(updated);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveClient(int id)
    {
      Client? eliminated = await this.clientRepository.DeleteClient(id);

      if (eliminated == null)
      {
        return NotFound();
      }
      return Ok(eliminated);

    }
  }
}

using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using RestServer.DTOs;
using RestServer.Interfaces;

namespace RestServer.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ServiceController : Controller
  {
    private readonly IServiceRepository ServiceRepository;

    public ServiceController(IServiceRepository ServiceRepository)
    {
      this.ServiceRepository = ServiceRepository;
    }

    [HttpGet]
    public async Task<ActionResult> GetServices()
    {
      return Ok(await this.ServiceRepository.GetServices());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetService(int id)
    {
      Service? encontrado = await this.ServiceRepository.GetService(id);

      if (encontrado == null)
      {
        return NotFound();
      }

      return Ok(encontrado);
    }

    [HttpPost]
    public async Task<IActionResult> PostService(ServiceDTO ServiceDTO)
    {
      try
      {
        return Ok(await this.ServiceRepository.PostService(ServiceDTO));
      }
      catch (Exception)
      {
        return BadRequest();
      }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutService(int id, ServiceDTO ServiceDTO)
    {
      Service? actualizado = await this.ServiceRepository.UpdateService(id, ServiceDTO);

      if (actualizado == null)
      {
        return NotFound();
      }
      return Ok(actualizado);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveService(int id)
    {
      Service? eliminado = await this.ServiceRepository.DeleteService(id);

      if (eliminado == null)
      {
        return NotFound();
      }
      return Ok(eliminado);

    }
  }
}

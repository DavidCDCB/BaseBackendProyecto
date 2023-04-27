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
    private readonly IServiceRepository serviceRepository;

    public ServiceController(IServiceRepository serviceRepository)
    {
      this.serviceRepository = serviceRepository;
    }

    [HttpGet]
    public async Task<ActionResult> GetServices()
    {
      return Ok(await this.serviceRepository.GetServices());
    }

    [HttpGet("page/{num}")]
    public async Task<ActionResult> GetSuppliersByPage(int num)
    {
      List<Service> services = await this.serviceRepository.GetByPage(num);
      return services.Count > 0 ? Ok(services) : NoContent();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetService(int id)
    {
      Service? find = await this.serviceRepository.GetService(id);

      if (find == null)
      {
        return NotFound();
      }

      return Ok(find);
    }

    [HttpPost]
    public async Task<IActionResult> PostService(ServiceDTO ServiceDTO)
    {
      try
      {
        return Ok(await this.serviceRepository.PostService(ServiceDTO));
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        return BadRequest(e);
      }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutService(int id, ServiceDTO ServiceDTO)
    {
      Service? updated = await this.serviceRepository.UpdateService(id, ServiceDTO);

      if (updated == null)
      {
        return NotFound();
      }
      return Ok(updated);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveService(int id)
    {
      Service? eliminated = await this.serviceRepository.DeleteService(id);

      if (eliminated == null)
      {
        return NotFound();
      }
      return Ok(eliminated);

    }
  }
}

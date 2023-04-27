using RestServer.DTOs;
using Microsoft.AspNetCore.Mvc;
using RestServer.Interfaces;
using Domain.Entities;

namespace RestServer.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class VehicleController : Controller
  {
    private readonly IVehicleRepository VehicleRepository;

    public VehicleController(IVehicleRepository VehicleRepository)
    {
      this.VehicleRepository = VehicleRepository;
    }

    [HttpGet]
    public async Task<ActionResult> GetVehicles()
    {
      return Ok(await this.VehicleRepository.GetVehicles());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetVehicle(int id)
    {
      Vehicle? find = await this.VehicleRepository.GetVehicle(id);

      if (find == null)
      {
        return NotFound();
      }

      return Ok(find);
    }

    [HttpGet("client/{id}")]
    public async Task<ActionResult> GetVehiclesByClient(int id)
    {
      return Ok(await this.VehicleRepository.GetVehiclesByClient(id));
    }

    [HttpPost]
    public async Task<IActionResult> PostVehicle(VehicleDTO VehicleDTO)
    {
      try
      {
        return Ok(await this.VehicleRepository.PostVehicle(VehicleDTO));
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        return BadRequest(e);
      }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutVehicle(int id, VehicleDTO VehicleDTO)
    {
      Vehicle? updated = await this.VehicleRepository.UpdateVehicle(id, VehicleDTO);

      if (updated == null)
      {
        return NotFound();
      }
      return Ok(updated);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveVehicle(int id)
    {
      Vehicle? eliminated = await this.VehicleRepository.DeleteVehicle(id);

      if (eliminated == null)
      {
        return NotFound();
      }
      return Ok(eliminated);

    }
  }
}

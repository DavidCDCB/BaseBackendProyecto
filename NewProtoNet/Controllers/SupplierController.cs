using RestServer.DTOs;
using Microsoft.AspNetCore.Mvc;
using RestServer.Interfaces;
using Domain.Entities.Base;
using Domain.Entities;

namespace RestServer.Controllers
{
  [ApiController]
  [Route("api/[controller]")] // https://localhost:7204/api/User
  public class SupplierController : Controller
  {
    private readonly ISupplierRepository supplierRepository;

    public SupplierController(ISupplierRepository supplierRepository)
    {
      this.supplierRepository = supplierRepository;
    }

    [HttpGet]
    public async Task<ActionResult> GetSuppliers()
    {
      return Ok(await this.supplierRepository.GetSuppliers());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetSupplier(int id)
    {
      Supplier? encontrado = await this.supplierRepository.GetSupplier(id);

      if (encontrado == null)
      {
        return NotFound();
      }

      return Ok(encontrado);
    }

    [HttpPost]
    public async Task<IActionResult> PostSupplier(SupplierDTO supplierDTO)
    {
      try
      {
        return Ok(await this.supplierRepository.PostSupplier(supplierDTO));
      }
      catch (Exception)
      {
        return BadRequest();
      }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutSupplier(int id, SupplierDTO supplierDTO)
    {
      Supplier actualizado = await this.supplierRepository.UpdateSupplier(id, supplierDTO);

      if (actualizado == null)
      {
        return NotFound();
      }
      return Ok(actualizado);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveSupplier(int id)
    {
      Supplier eliminado = await this.supplierRepository.DeleteSupplier(id);

      if (eliminado == null)
      {
        return NotFound();
      }
      return Ok(eliminado);

    }
  }
}

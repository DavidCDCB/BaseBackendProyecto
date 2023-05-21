using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using RestServer.DTOs;
using RestServer.Interfaces;

// https://localhost:7204/swagger/index.html
namespace RestServer.Controllers
{
    [ApiController]
  [Route("api/[controller]")] // https://localhost:7204/api/Inconvenient
  public class InconvenientController : Controller
  {
    private readonly IInconvenientRepository inconvenientRepository;

    public InconvenientController(IInconvenientRepository inconvenientRepository)
    {
      this.inconvenientRepository = inconvenientRepository;
    }


    [HttpGet("seed/{size}")]
    public IActionResult SeedData(int size)
    {
      return Ok(this.inconvenientRepository.SeedInconvenients(size));
    }

    [HttpGet]
    public async Task<ActionResult> GetInconvenients()
    {
      Console.WriteLine("OK");
      return Ok(await this.inconvenientRepository.GetInconvenients());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetInconvenient(int id)
    {
      Inconvenient encontrado = await this.inconvenientRepository.GetInconvenient(id);

      if (encontrado == null)
      {
        return NotFound();
      }

      return Ok(encontrado);
    }

    /*
     * Inserción de datos anidados
    {
      "fullName": "Completo",
      "email": "string",
      "phone": 0,
      "courses": [
        {
          "name": "string",
          "level": "string",
          "description": "string",
        }
      ]
    }
     */
    [HttpPost]
    public async Task<IActionResult> PostInconvenient(InconvenientDTO inconvenient)
    {
      try
      {
        return Ok(await this.inconvenientRepository.PostInconvenient(inconvenient));
      }
      catch (Exception)
      {
        return BadRequest();
      }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutInconvenient(int id, InconvenientDTO inconvenient)
    {
      Inconvenient actualizado = await this.inconvenientRepository.UpdateInconvenient(id, inconvenient);
      
      if (actualizado == null)
      {
        return NotFound();
      }
      return Ok(actualizado);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveInconvenient(int id)
    {
      Inconvenient eliminado = await this.inconvenientRepository.DeleteInconvenient(id);

      if (eliminado == null)
      {
        return NotFound();
      }
      return Ok(eliminado);

    }
  }
}

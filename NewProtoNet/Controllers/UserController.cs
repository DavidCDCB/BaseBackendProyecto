using NewProtoNet.DTOs;
using Microsoft.AspNetCore.Mvc;
using NewProtoNet.Interfaces;
using Domain.Entities.Base;

// https://localhost:7204/swagger/index.html
namespace NewProtoNet.Controllers
{
    [ApiController]
  [Route("api/[controller]")] // https://localhost:7204/api/User
  public class UserController : Controller
  {
    private readonly IUserRepository userRepository;

    public UserController(IUserRepository userRepository)
    {
      this.userRepository = userRepository;
    }


    [HttpGet("seed/{size}")]
    public IActionResult SeedData(int size)
    {
      return Ok(this.userRepository.SeedUsers(size));
    }

    [HttpGet]
    public async Task<ActionResult> GetUsers()
    {
      Console.WriteLine("OK");
      return Ok(await this.userRepository.GetUsers());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetUser(int id)
    {
      User encontrado = await this.userRepository.GetUser(id);

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
    public async Task<IActionResult> PostUser(UserDTO user)
    {
      try
      {
        return Ok(await this.userRepository.PostUser(user));
      }
      catch (Exception)
      {
        return BadRequest();
      }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutUser(int id, UserDTO user)
    {
      User actualizado = await this.userRepository.UpdateUser(id, user);
      
      if (actualizado == null)
      {
        return NotFound();
      }
      return Ok(actualizado);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveUser(int id)
    {
      User eliminado = await this.userRepository.DeleteUser(id);

      if (eliminado == null)
      {
        return NotFound();
      }
      return Ok(eliminado);

    }
  }
}

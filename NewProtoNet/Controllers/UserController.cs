using RestServer.DTOs;
using Microsoft.AspNetCore.Mvc;
using RestServer.Interfaces;
using Domain.Entities;

namespace RestServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserRepository UserRepository;

        public UserController(IUserRepository UserRepository)
        {
            this.UserRepository = UserRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetUsers()
        {
            return Ok(await this.UserRepository.GetUsers());
        }

        [HttpGet("page/{num}")]
        public async Task<ActionResult> GetUsersByPage(int num)
        {
            List<User> Users = await this.UserRepository.GetByPage(num);
            return Users.Count > 0 ? Ok(Users) : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetUser(int id)
        {
            User? encontrado = await this.UserRepository.GetUser(id);

            if (encontrado == null)
            {
                return NotFound();
            }

            return Ok(encontrado);
        }

        [HttpPost]
        public async Task<IActionResult> PostUser(UserDTO UserDTO)
        {
            try
            {
                return Ok(await this.UserRepository.PostUser(UserDTO));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, UserDTO UserDTO)
        {
            User? actualizado = await this.UserRepository.UpdateUser(id, UserDTO);

            if (actualizado == null)
            {
                return NotFound();
            }
            return Ok(actualizado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveUser(int id)
        {
            User? eliminado = await this.UserRepository.DeleteUser(id);

            if (eliminado == null)
            {
                return NotFound();
            }
            return Ok(eliminado);

        }
    }
}
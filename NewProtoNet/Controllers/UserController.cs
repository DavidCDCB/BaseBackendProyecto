﻿using Microsoft.AspNetCore.Mvc;
using NewProtoNet.Interfaces;
using NewProtoNet.Models;

namespace NewProtoNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // api/User
    public class UserController : Controller
    {
        //private readonly UserDbContext dbContext;
        private readonly IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            //this.dbContext = dbContext;
            this.userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(this.userRepository.GetUsers());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var encontrado = await this.userRepository.GetUser(id);

            if(encontrado == null)
            {
                return NotFound();
            }

            return Ok(encontrado);
        }

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
            var actualizado = await this.userRepository.UpdateUser(id, user);

            if(actualizado == null)
            {
                return NotFound();
            }
            return Ok(actualizado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveUser(int id)
        {
            var eliminado = await this.userRepository.DeleteUser(id);

            if (eliminado == null)
            {
                return NotFound();
            }
            return Ok(eliminado);

        }
    }
}

﻿using RestServer.DTOs;
﻿using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestServer.Interfaces;
using Domain.Entities;

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace RestServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserRepository UserRepository;
        private IConfiguration config;

        public UserController(IUserRepository UserRepository)
        {
            this.UserRepository = UserRepository;
            this.config = config;
        }

        //[Authorize(Policy = "PayrollLimit")]
        [HttpGet]
        public async Task<ActionResult> GetUsers()
        {
            return Ok(await this.UserRepository.GetUsers());
        }

        //[Authorize(Policy = "PayrollLimit")]
        [HttpGet("page/{num}")]
        public async Task<ActionResult> GetUsersByPage(int num)
        {
            List<User> Users = await this.UserRepository.GetByPage(num);
            return Users.Count > 0 ? Ok(Users) : NoContent();
        }

        //[Authorize(Policy = "PayrollLimit")]
        [HttpGet("{id}")]
        public async Task<ActionResult> GetUser(int id)
        {
            User? find = await this.UserRepository.GetUser(id);

            if (find == null)
            {
                return NotFound();
            }

            return Ok(find);
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

        //[Authorize(Policy = "PayrollLimit")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, UserDTO UserDTO)
        {
            User? updated = await this.UserRepository.UpdateUser(id, UserDTO);

            if (updated == null)
            {
                return NotFound();
            }
            return Ok(updated);
        }

        //[Authorize(Policy = "PayrollLimit")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveUser(int id)
        {
            User? eliminated = await this.UserRepository.DeleteUser(id);

            if (eliminated == null)
            {
                return NotFound();
            }
            return Ok(eliminated);

        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO userDTO)
        {
            User? user = await this.UserRepository.GetUserCredentials(userDTO);
            if (user == null)
            {
                return BadRequest(new {Message = "Invalid credentials"});
            }
            string jwt = GenerateToken(user);
            return Ok(new {token = jwt});
        }
        
        private string GenerateToken(User user)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Email),
                new Claim("roles", user.role)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("JWTAuthenticationHIGHsecuredPasswordVVVp1OH7Xzyr"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var securityToken = new JwtSecurityToken(
                               claims: claims,
                               expires: DateTime.Now.AddMinutes(60),
                               signingCredentials: creds);

            string token = new JwtSecurityTokenHandler().WriteToken(securityToken); 
            return token + ' ' + user.role;
        }
    }
}

using RestServer.DTOs;
using Microsoft.AspNetCore.Mvc;
using RestServer.Interfaces;
using Domain.Entities;

namespace RestServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdministratorController : Controller
    {
        private readonly IAdministratorRepository AdministratorRepository;

        public AdministratorController(IAdministratorRepository AdministratorRepository)
        {
            this.AdministratorRepository = AdministratorRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAdministrators()
        {
            return Ok(await this.AdministratorRepository.GetAdministrators());
        }

        [HttpGet("page/{num}")]
        public async Task<ActionResult> GetAdministratorsByPage(int num)
        {
            List<Administrator> Administrators = await this.AdministratorRepository.GetByPage(num);
            return Administrators.Count > 0 ? Ok(Administrators) : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetAdministrator(int id)
        {
            Administrator? encontrado = await this.AdministratorRepository.GetAdministrator(id);

            if (encontrado == null)
            {
                return NotFound();
            }

            return Ok(encontrado);
        }

        [HttpPost]
        public async Task<IActionResult> PostAdministrator(AdministratorDTO AdministratorDTO)
        {
            try
            {
                return Ok(await this.AdministratorRepository.PostAdministrator(AdministratorDTO));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdministrator(int id, AdministratorDTO AdministratorDTO)
        {
            Administrator? actualizado = await this.AdministratorRepository.UpdateAdministrator(id, AdministratorDTO);

            if (actualizado == null)
            {
                return NotFound();
            }
            return Ok(actualizado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveAdministrator(int id)
        {
            Administrator? eliminado = await this.AdministratorRepository.DeleteAdministrator(id);

            if (eliminado == null)
            {
                return NotFound();
            }
            return Ok(eliminado);

        }
    }
}
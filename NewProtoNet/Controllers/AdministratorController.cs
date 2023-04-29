using RestServer.DTOs;
using Microsoft.AspNetCore.Mvc;
using RestServer.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;

namespace RestServer.Controllers
{

    [Authorize(Policy = "PayrollLimit")]
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
            Administrator? find = await this.AdministratorRepository.GetAdministrator(id);

            if (find == null)
            {
                return NotFound();
            }

            return Ok(find);
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
            Administrator? updated = await this.AdministratorRepository.UpdateAdministrator(id, AdministratorDTO);

            if (updated == null)
            {
                return NotFound();
            }
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveAdministrator(int id)
        {
            Administrator? eliminated = await this.AdministratorRepository.DeleteAdministrator(id);

            if (eliminated == null)
            {
                return NotFound();
            }
            return Ok(eliminated);

        }
    }
}
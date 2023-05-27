using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestServer.DTOs;
using RestServer.Interfaces;

// https://localhost:7204/swagger/index.html
namespace RestServer.Controllers
{
    //[Authorize(Policy = "PayrollLimit")]
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
            Inconvenient find = await this.inconvenientRepository.GetInconvenient(id);

            if (find == null)
            {
                return NotFound();
            }

            return Ok(find);
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
            Inconvenient updated = await this.inconvenientRepository.UpdateInconvenient(id, inconvenient);

            if (updated == null)
            {
                return NotFound();
            }
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveInconvenient(int id)
        {
            Inconvenient eliminated = await this.inconvenientRepository.DeleteInconvenient(id);

            if (eliminated == null)
            {
                return NotFound();
            }
            return Ok(eliminated);

        }
        [HttpGet("page/{num}")]
        public async Task<ActionResult> GetInconvenientsByPage(int num)
        {
            List<Inconvenient> inconvenients = await this.inconvenientRepository.GetByPage(num);
            return inconvenients.Count > 0 ? Ok(inconvenients) : NoContent();
        }
    }
}

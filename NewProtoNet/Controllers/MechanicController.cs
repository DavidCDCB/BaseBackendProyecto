using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using RestServer.DTOs;
using RestServer.Interfaces;

namespace RestServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]// https://localhost:7204/api/Mechanic
    public class MechanicController : Controller
    {
        private readonly IMechanicRepository mechanicRepository;

        public MechanicController(IMechanicRepository mechanicRepository)
        {
            this.mechanicRepository = mechanicRepository;
        }


        [HttpGet("seed/{size}")]
        public IActionResult SeedData(int size)
        {
            return Ok(this.mechanicRepository.SeedMechanics(size));
        }

        [HttpGet]
        public async Task<ActionResult> GetMechanics()
        {
            Console.WriteLine("OK");
            return Ok(await this.mechanicRepository.GetMechanics());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetMechanic(int id)
        {
            Mechanic find = await this.mechanicRepository.GetMechanic(id);

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
        public async Task<IActionResult> PostMechanic(MechanicDTO mechanic)
        {
            try
            {
                return Ok(await this.mechanicRepository.PostMechanic(mechanic));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMechanic(int id, MechanicDTO mechanic)
        {
            Mechanic updated = await this.mechanicRepository.UpdateMechanic(id, mechanic);

            if (updated == null)
            {
                return NotFound();
            }
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveMechanic(int id)
        {
            Mechanic eliminated = await this.mechanicRepository.DeleteMechanic(id);

            if (eliminated == null)
            {
                return NotFound();
            }
            return Ok(eliminated);

        }
        [HttpGet("page/{num}")]
        public async Task<ActionResult> GetMechanicsByPage(int num)
        {
            List<Mechanic> mechanics = await this.mechanicRepository.GetByPage(num);
            return mechanics.Count > 0 ? Ok(mechanics) : NoContent();
        }
    }
}

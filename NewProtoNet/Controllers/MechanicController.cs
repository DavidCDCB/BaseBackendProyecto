using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using NewProtoNet.DTOs;
using NewProtoNet.Interfaces;

namespace NewProtoNet.Controllers
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
            Mechanic encontrado = await this.mechanicRepository.GetMechanic(id);

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
            Mechanic actualizado = await this.mechanicRepository.UpdateMechanic(id, mechanic);

            if (actualizado == null)
            {
                return NotFound();
            }
            return Ok(actualizado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveMechanic(int id)
        {
            Mechanic eliminado = await this.mechanicRepository.DeleteMechanic(id);

            if (eliminado == null)
            {
                return NotFound();
            }
            return Ok(eliminado);

        }
    }
}

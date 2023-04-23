using RestServer.DTOs;
using Microsoft.AspNetCore.Mvc;
using RestServer.Interfaces;
using Domain.Entities;

namespace RestServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecepcionistController : Controller
    {
        private readonly IRecepcionistRepository RecepcionistRepository;

        public RecepcionistController(IRecepcionistRepository RecepcionistRepository)
        {
            this.RecepcionistRepository = RecepcionistRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetRecepcionists()
        {
            return Ok(await this.RecepcionistRepository.GetRecepcionists());
        }

        [HttpGet("page/{num}")]
        public async Task<ActionResult> GetRecepcionistsByPage(int num)
        {
            List<Recepcionist> Recepcionists = await this.RecepcionistRepository.GetByPage(num);
            return Recepcionists.Count > 0 ? Ok(Recepcionists) : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetRecepcionist(int id)
        {
            Recepcionist? encontrado = await this.RecepcionistRepository.GetRecepcionist(id);

            if (encontrado == null)
            {
                return NotFound();
            }

            return Ok(encontrado);
        }

        [HttpPost]
        public async Task<IActionResult> PostRecepcionist(RecepcionistDTO RecepcionistDTO)
        {
            try
            {
                return Ok(await this.RecepcionistRepository.PostRecepcionist(RecepcionistDTO));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecepcionist(int id, RecepcionistDTO RecepcionistDTO)
        {
            Recepcionist? actualizado = await this.RecepcionistRepository.UpdateRecepcionist(id, RecepcionistDTO);

            if (actualizado == null)
            {
                return NotFound();
            }
            return Ok(actualizado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveRecepcionist(int id)
        {
            Recepcionist? eliminado = await this.RecepcionistRepository.DeleteRecepcionist(id);

            if (eliminado == null)
            {
                return NotFound();
            }
            return Ok(eliminado);

        }
    }
}
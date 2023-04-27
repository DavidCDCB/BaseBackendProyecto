using RestServer.DTOs;
using Microsoft.AspNetCore.Mvc;
using RestServer.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;

namespace RestServer.Controllers
{

    [Authorize(Policy = "Administrator")]
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
            Recepcionist? find = await this.RecepcionistRepository.GetRecepcionist(id);

            if (find == null)
            {
                return NotFound();
            }

            return Ok(find);
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
            Recepcionist? updated = await this.RecepcionistRepository.UpdateRecepcionist(id, RecepcionistDTO);

            if (updated == null)
            {
                return NotFound();
            }
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveRecepcionist(int id)
        {
            Recepcionist? eliminated = await this.RecepcionistRepository.DeleteRecepcionist(id);

            if (eliminated == null)
            {
                return NotFound();
            }
            return Ok(eliminated);

        }
    }
}
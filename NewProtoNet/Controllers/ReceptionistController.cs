using RestServer.DTOs;
using Microsoft.AspNetCore.Mvc;
using RestServer.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;

namespace RestServer.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ReceptionistController : Controller
    {
        private readonly IReceptionistRepository ReceptionistRepository;

        public ReceptionistController(IReceptionistRepository ReceptionistRepository)
        {
            this.ReceptionistRepository = ReceptionistRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetReceptionists()
        {
            return Ok(await this.ReceptionistRepository.GetReceptionists());
        }

        [HttpGet("user_id")]
        public async Task<ActionResult> GetReceptionistsUsers()
        {
            return Ok(await this.ReceptionistRepository.GetReceptionistsUsers());
        }

        [HttpGet("page/{num}")]
        public async Task<ActionResult> GetReceptionistsByPage(int num)
        {
            List<Receptionist> Receptionists = await this.ReceptionistRepository.GetByPage(num);
            return Receptionists.Count > 0 ? Ok(Receptionists) : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetReceptionist(int id)
        {
            Receptionist? find = await this.ReceptionistRepository.GetReceptionist(id);

            if (find == null)
            {
                return NotFound();
            }

            return Ok(find);
        }

        [HttpPost]
        public async Task<IActionResult> PostReceptionist(ReceptionistDTO ReceptionistDTO)
        {
            try
            {
                return Ok(await this.ReceptionistRepository.PostReceptionist(ReceptionistDTO));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutReceptionist(int id, ReceptionistDTO ReceptionistDTO)
        {
            Receptionist? updated = await this.ReceptionistRepository.UpdateReceptionist(id, ReceptionistDTO);

            if (updated == null)
            {
                return NotFound();
            }
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveReceptionist(int id)
        {
            Receptionist? eliminated = await this.ReceptionistRepository.DeleteReceptionist(id);

            if (eliminated == null)
            {
                return NotFound();
            }
            return Ok(eliminated);

        }
    }
}
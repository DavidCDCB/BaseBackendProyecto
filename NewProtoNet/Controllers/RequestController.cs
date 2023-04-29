using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestServer.DTOs;
using RestServer.Interfaces;

namespace RestServer.Controllers
{
    [Authorize(Policy = "PayrollLimit")]
    [ApiController]
    [Route("api/[controller]")]
    public class RequestController : Controller
    {
        private readonly IRequestRepository requestRepository;

        public RequestController(IRequestRepository requestRepository)
        {
            this.requestRepository = requestRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetRequests()
        {
            return Ok(await this.requestRepository.GetRequests());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetRequest(int id)
        {
            RequestDTO? find = await this.requestRepository.GetRequest(id);

            if (find == null)
            {
                return NotFound();
            }

            return Ok(find);
        }

        [HttpGet("service/{id}")]
        public async Task<ActionResult> GetRequestByService(int id)
        {
            return Ok(await this.requestRepository.GetRequestsByService(id));
        }

        [HttpGet("client/{id}")]
        public async Task<ActionResult> GetRequestByClient(int id)
        {
            return Ok(await this.requestRepository.GetRequestsByClient(id));
        }

        [HttpPost]
        public async Task<IActionResult> PostRequest(RequestDTO RequestDTO)
        {
            try
            {
                return Ok(await this.requestRepository.PostRequest(RequestDTO));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutRequest(int id, RequestDTO RequestDTO)
        {
            RequestDTO? updated = await this.requestRepository.UpdateRequest(id, RequestDTO);

            if (updated == null)
            {
                return NotFound();
            }
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveRequest(int id)
        {
            RequestDTO? eliminated = await this.requestRepository.DeleteRequest(id);

            if (eliminated == null)
            {
                return NotFound();
            }
            return Ok(eliminated);

        }
    }
}

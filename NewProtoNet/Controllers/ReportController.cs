using RestServer.DTOs;
using Microsoft.AspNetCore.Mvc;
using RestServer.Interfaces;
using Domain.Entities;

namespace RestServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController : Controller
    {
        private readonly IReportRepository ReportRepository;

        public ReportController(IReportRepository ReportRepository)
        {
            this.ReportRepository = ReportRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetReports()
        {
            return Ok(await this.ReportRepository.GetReports());
        }

        [HttpGet("page/{num}")]
        public async Task<ActionResult> GetReportsByPage(int num)
        {
            List<Report> Reports = await this.ReportRepository.GetByPage(num);
            return Reports.Count > 0 ? Ok(Reports) : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetReport(int id)
        {
            Report? encontrado = await this.ReportRepository.GetReport(id);

            if (encontrado == null)
            {
                return NotFound();
            }

            return Ok(encontrado);
        }

        [HttpPost]
        public async Task<IActionResult> PostReport(ReportDTO ReportDTO)
        {
            try
            {
                return Ok(await this.ReportRepository.PostReport(ReportDTO));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutReport(int id, ReportDTO ReportDTO)
        {
            Report? actualizado = await this.ReportRepository.UpdateReport(id, ReportDTO);

            if (actualizado == null)
            {
                return NotFound();
            }
            return Ok(actualizado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveReport(int id)
        {
            Report? eliminado = await this.ReportRepository.DeleteReport(id);

            if (eliminado == null)
            {
                return NotFound();
            }
            return Ok(eliminado);

        }
    }
}
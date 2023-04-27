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
            Report? find = await this.ReportRepository.GetReport(id);

            if (find == null)
            {
                return NotFound();
            }

            return Ok(find);
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
            Report? updated = await this.ReportRepository.UpdateReport(id, ReportDTO);

            if (updated == null)
            {
                return NotFound();
            }
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveReport(int id)
        {
            Report? eliminated = await this.ReportRepository.DeleteReport(id);

            if (eliminated == null)
            {
                return NotFound();
            }
            return Ok(eliminated);

        }
    }
}
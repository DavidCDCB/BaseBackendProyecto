using RestServer.DTOs;
using Microsoft.AspNetCore.Mvc;
using RestServer.Interfaces;
using Domain.Entities;

// https://localhost:7204/swagger/index.html
namespace RestServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // https://localhost:7204/api/Payroll
    public class PayrollController : Controller
    {
        private readonly IPayrollRepository payrollRepository;

        public PayrollController(IPayrollRepository payrollRepository)
        {
            this.payrollRepository = payrollRepository;
        }


        [HttpGet("seed/{size}")]
        public IActionResult SeedData(int size)
        {
            return Ok(this.payrollRepository.SeedPayrolls(size));
        }

        [HttpGet]
        public async Task<ActionResult> GetPayrolls()
        {
            Console.WriteLine("OK");
            return Ok(await this.payrollRepository.GetPayrolls());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetPayroll(int id)
        {
            Payroll find = await this.payrollRepository.GetPayroll(id);

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
        public async Task<IActionResult> PostPayroll(PayrollDTO payroll)
        {
            try
            {
                return Ok(await this.payrollRepository.PostPayroll(payroll));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPayroll(int id, PayrollDTO payroll)
        {
            Payroll updated = await this.payrollRepository.UpdatePayroll(id, payroll);

            if (updated == null)
            {
                return NotFound();
            }
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemovePayroll(int id)
        {
            Payroll eliminated = await this.payrollRepository.DeletePayroll(id);

            if (eliminated == null)
            {
                return NotFound();
            }
            return Ok(eliminated);

        }
        [HttpGet("page/{num}")]
        public async Task<ActionResult> GetPayrollsByPage(int num)
        {
            List<Payroll> payrolls = await this.payrollRepository.GetByPage(num);
            return payrolls.Count > 0 ? Ok(payrolls) : NoContent();
        }
    }
}

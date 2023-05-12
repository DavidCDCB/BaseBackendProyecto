using RestServer.DTOs;
using Microsoft.AspNetCore.Mvc;
using RestServer.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;

namespace RestServer.Controllers
{
    //[Authorize(Policy = "PayrollLimit")]
    [ApiController]
    [Route("api/[controller]")]
    public class SupplierController : Controller
    {
        private readonly ISupplierRepository supplierRepository;

        public SupplierController(ISupplierRepository supplierRepository)
        {
            this.supplierRepository = supplierRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetSuppliers()
        {
            return Ok(await this.supplierRepository.GetSuppliers());
        }

        [HttpGet("page/{num}")]
        public async Task<ActionResult> GetSuppliersByPage(int num)
        {
            List<Supplier> suppliers = await this.supplierRepository.GetByPage(num);
            return suppliers.Count > 0 ? Ok(suppliers) : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetSupplier(int id)
        {
            Supplier? find = await this.supplierRepository.GetSupplier(id);

            if (find == null)
            {
                return NotFound();
            }

            return Ok(find);
        }

        [HttpPost]
        public async Task<IActionResult> PostSupplier(SupplierDTO supplierDTO)
        {
            try
            {
                return Ok(await this.supplierRepository.PostSupplier(supplierDTO));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplier(int id, SupplierDTO supplierDTO)
        {
            Supplier? updated = await this.supplierRepository.UpdateSupplier(id, supplierDTO);

            if (updated == null)
            {
                return NotFound();
            }
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveSupplier(int id)
        {
            Supplier? eliminated = await this.supplierRepository.DeleteSupplier(id);

            if (eliminated == null)
            {
                return NotFound();
            }
            return Ok(eliminated);

        }
    }
}

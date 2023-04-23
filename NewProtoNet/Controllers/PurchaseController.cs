using RestServer.DTOs;
using Microsoft.AspNetCore.Mvc;
using RestServer.Interfaces;
using Domain.Entities;

namespace RestServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PurchaseController : Controller
    {
        private readonly IPurchaseRepository PurchaseRepository;

        public PurchaseController(IPurchaseRepository PurchaseRepository)
        {
            this.PurchaseRepository = PurchaseRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetPurchases()
        {
            return Ok(await this.PurchaseRepository.GetPurchases());
        }

        [HttpGet("page/{num}")]
        public async Task<ActionResult> GetPurchasesByPage(int num)
        {
            List<Purchase> Purchases = await this.PurchaseRepository.GetByPage(num);
            return Purchases.Count > 0 ? Ok(Purchases) : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetPurchase(int id)
        {
            Purchase? encontrado = await this.PurchaseRepository.GetPurchase(id);

            if (encontrado == null)
            {
                return NotFound();
            }

            return Ok(encontrado);
        }

        [HttpPost]
        public async Task<IActionResult> PostPurchase(PurchaseDTO PurchaseDTO)
        {
            try
            {
                return Ok(await this.PurchaseRepository.PostPurchase(PurchaseDTO));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchase(int id, PurchaseDTO PurchaseDTO)
        {
            Purchase? actualizado = await this.PurchaseRepository.UpdatePurchase(id, PurchaseDTO);

            if (actualizado == null)
            {
                return NotFound();
            }
            return Ok(actualizado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemovePurchase(int id)
        {
            Purchase? eliminado = await this.PurchaseRepository.DeletePurchase(id);

            if (eliminado == null)
            {
                return NotFound();
            }
            return Ok(eliminado);

        }
    }
}
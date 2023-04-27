using RestServer.DTOs;
using Microsoft.AspNetCore.Mvc;
using RestServer.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;

namespace RestServer.Controllers
{

    [Authorize(Policy = "Recepcionist")]
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductRepository ProductRepository;

        public ProductController(IProductRepository ProductRepository)
        {
            this.ProductRepository = ProductRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            return Ok(await this.ProductRepository.GetProducts());
        }

        [HttpGet("page/{num}")]
        public async Task<ActionResult> GetProductsByPage(int num)
        {
            List<Product> Products = await this.ProductRepository.GetByPage(num);
            return Products.Count > 0 ? Ok(Products) : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetProduct(int id)
        {
            Product? find = await this.ProductRepository.GetProduct(id);

            if (find == null)
            {
                return NotFound();
            }

            return Ok(find);
        }

        [HttpPost]
        public async Task<IActionResult> PostProduct(ProductDTO ProductDTO)
        {
            try
            {
                return Ok(await this.ProductRepository.PostProduct(ProductDTO));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, ProductDTO ProductDTO)
        {
            Product? updated = await this.ProductRepository.UpdateProduct(id, ProductDTO);

            if (updated == null)
            {
                return NotFound();
            }
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveProduct(int id)
        {
            Product? eliminated = await this.ProductRepository.DeleteProduct(id);

            if (eliminated == null)
            {
                return NotFound();
            }
            return Ok(eliminated);

        }
    }
}
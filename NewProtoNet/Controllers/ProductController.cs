using RestServer.DTOs;
using Microsoft.AspNetCore.Mvc;
using RestServer.Interfaces;
using Domain.Entities;

namespace RestServer.Controllers
{
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
            Product? encontrado = await this.ProductRepository.GetProduct(id);

            if (encontrado == null)
            {
                return NotFound();
            }

            return Ok(encontrado);
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
            Product? actualizado = await this.ProductRepository.UpdateProduct(id, ProductDTO);

            if (actualizado == null)
            {
                return NotFound();
            }
            return Ok(actualizado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveProduct(int id)
        {
            Product? eliminado = await this.ProductRepository.DeleteProduct(id);

            if (eliminado == null)
            {
                return NotFound();
            }
            return Ok(eliminado);

        }
    }
}
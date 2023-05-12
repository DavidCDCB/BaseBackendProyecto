using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using RestServer.Data;
using RestServer.DTOs;
using RestServer.Interfaces;
using System.Drawing.Printing;

namespace RestServer.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private readonly BaseDbContext dbContext;

        public ProductRepository(BaseDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        async Task<List<Product>> IProductRepository.GetProducts()
        {
            return await this.dbContext.Products!.ToListAsync();
        }

        async Task<Product?> IProductRepository.GetProduct(int id)
        {
            Product? Product = await dbContext.Products!.FirstOrDefaultAsync(m => m.Id == id);
            return (Product != null) ? Product : null;
        }

        async Task<Product> IProductRepository.PostProduct(ProductDTO ProductDTO)
        {

            Product Product = new Product()
            {
                Name = ProductDTO.Name,
                Code = ProductDTO.Code,
                Brand = ProductDTO.Brand,
                salePrice = ProductDTO.salePrice,
                Quantity = ProductDTO.Quantity,
                Description = ProductDTO.Description,             
            };

            await this.dbContext.Products!.AddAsync(Product);
            await this.dbContext.SaveChangesAsync();

            return Product;
        }

        async Task<Product?> IProductRepository.UpdateProduct(int id, ProductDTO Product)
        {
            Product? find = await this.dbContext.Products!.FindAsync(id);
            if (find == null)
            {
                return find;
            }

            find.Name = Product.Name;
            find.Code = Product.Code;
            find.Brand = Product.Brand;
            find.salePrice = Product.salePrice;
            find.Quantity = Product.Quantity;
            find.Description = Product.Description;
            await this.dbContext.SaveChangesAsync();

            return find;
        }

        async Task<Product?> IProductRepository.DeleteProduct(int id)
        {
            Product? find = await dbContext.Products!.FindAsync(id);
            if (find != null)
            {
                this.dbContext.Remove(find);
                this.dbContext.SaveChanges();
            }
            return find!;
        }

        async Task<List<Product>> IProductRepository.GetByPage(int page)
        {
            const int pageSize = 10;
            List<Product> Products = await this.dbContext.Products!.ToListAsync();
            int totalPages = (int)Math.Ceiling((double)Products.Count / pageSize);
            return (page <= totalPages) ? Products.Skip((page - 1) * pageSize).Take(pageSize).ToList() : new List<Product>();
        }
    }
}
using Domain.Entities;
using RestServer.DTOs;

namespace RestServer.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts();
        Task<List<Product>> GetByPage(int page);
        Task<Product> GetProduct(int id);
        Task<Product> PostProduct(ProductDTO Product);
        Task<Product> UpdateProduct(int id, ProductDTO Product);
        Task<Product> DeleteProduct(int id);
    }
}

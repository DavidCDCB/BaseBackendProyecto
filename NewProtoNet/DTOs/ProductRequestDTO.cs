using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServer.DTOs
{
    public class ProductRequestDTO
    {
        public List<int> ProductsId { get; set; }
        public int RequestsId { get; set; }
    }
}

using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServer.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Brand { get; set; }
        public float? salePrice { get; set; }
        public int? Quantity { get; set; }
        public string? Description { get; set; }
    }
}

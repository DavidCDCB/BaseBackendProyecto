using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServer.DTOs
{
    public class ProductRequestDTO
    {
        public List<Product>? Products { get; set; }
        public List<Mechanic>? Mechanics { get; set; }
        public int RequestsId { get; set; }
        public int ClientId { get; set; }
        public int ServiceId { get; set; }
    }
}

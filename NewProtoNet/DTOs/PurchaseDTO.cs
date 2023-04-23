using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServer.DTOs
{
    public class PurchaseDTO
    {
        public int Id { get; set; }
        public float? purchasePrice { get; set; }
        public float? salePrice { get; set; }
        public int? Quantity { get; set; }
        public string? Description { get; set; }
        public string? Code { get; set; }
        public DateOnly? datePurchase { get; set; }
    }
}

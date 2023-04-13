using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Purchase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public float? purchasePrice { get; set; }
        [Required]
        public float? salePrice { get; set; }
        [Required]
        public int? Quantity { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Code { get; set; }
        [Required]
        public DateOnly? datePurchase { get; set; }

        public int? ProductId { get; set; }
        public Product? Product { get; set; }

        public int? SupplierId { get; set; }
        public Supplier? Supplier { get; set; }

    }
}

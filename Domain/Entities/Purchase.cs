using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("purchases")]
    public class Purchase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("purchaseprice")]
        public float? purchasePrice { get; set; }
        [Required]
        [Column("saleprice")]
        public float? salePrice { get; set; }
        [Required]
        [Column("quantity")]
        public int? Quantity { get; set; }
        [Required]
        [Column("description")]
        public string? Description { get; set; }
        [Required]
        [Column("code")]
        public string? Code { get; set; }
        [Required]
        [Column("datepurchase")]
        public DateOnly? datePurchase { get; set; }

        [Column("product_id")]
        public int? ProductId { get; set; }
        public Product? Product { get; set; }

        [Column("supplier_id")]
        public int? SupplierId { get; set; }
        public Supplier? Supplier { get; set; }

    }
}

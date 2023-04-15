using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class purchases
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

        [Column("productid")]
        public int? ProductId { get; set; }
        public products? Product { get; set; }

        [Column("supplierid")]
        public int? SupplierId { get; set; }
        public suppliers? Supplier { get; set; }

    }
}

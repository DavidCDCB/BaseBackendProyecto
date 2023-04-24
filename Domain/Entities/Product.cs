using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        public string? Name { get; set; }
        [Required]
        [Column("code")]
        public string? Code { get; set; }
        [Required]
        [Column("brand")]
        public string? Brand { get; set; }
        [Required]
        [Column("saleprice")]
        public float? salePrice { get; set; }
        [Required]
        [Column("quantity")]
        public int? Quantity { get; set; }
        [Required]
        [Column("description")]
        public string? Description { get; set; }

        public ICollection<Purchase>? purchases { get; set; }
        public ICollection<Request>? Requests { get; set; }
    }
}

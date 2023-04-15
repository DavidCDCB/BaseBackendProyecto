using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class products
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

        public ICollection<purchases>? purchases { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Code { get; set; }
        [Required]
        public string? Brand { get; set; }
        [Required]
        public float? Price { get; set; }
        [Required]
        public int? Quantity { get; set; }
        [Required]
        public string? Description { get; set; }

    }
}

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
        public float? buyoutPrice { get; set; }
        [Required]
        public int? Quantity { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Code { get; set; }

        public int? ProductId { get; set; }
        public Product? Product { get; set; }

    }
}

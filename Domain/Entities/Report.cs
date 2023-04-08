using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Report
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string? Type { get; set; }
        [Required]

        public int? AdministratorId { get; set; }
        public Administrator? Administrator { get; set; }
    }
}

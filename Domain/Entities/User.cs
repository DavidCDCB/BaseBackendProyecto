using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("email")]
        public string? Email { get; set; }
        [Required]
        [Column("password")]
        public string? Password { get; set; }
        [Required]
        [Column("role")]
        public string? role { get; set; }

        public Administrator? Administrator { get; set; }
        public Receptionist? Receptionist { get; set; }

        public Mechanic? Mechanic { get; set; }
        public Client? Client { get; set; }
    }
}

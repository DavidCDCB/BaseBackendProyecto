using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class users
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
        public string? Role { get; set; }

        public administrators? Administrator { get; set; }
        public recepcionists? Recepcionist { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("admins")]
    public class Administrator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        public string? Name { get; set; }
        [Required]
        [Column("surname")]
        public string? Surname { get; set; }
        [Required]
        [Column("phone")]
        public string? Phone { get; set; }

        [Column("user_id")]
        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}

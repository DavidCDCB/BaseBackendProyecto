using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class administrators
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
        public string? SurName { get; set; }
        [Required]
        [Column("phone")]
        public string? Phone { get; set; }

        [Column("userid")]
        public int? UserId { get; set; }
        public users? User { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("mechanics")]
    public class Mechanic
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
        [Required]
        [Column("role")]
        public string? Role { get; set; }
        [Required]
        [Column("email")]
        public string? Email { get; set; }
        [Required]
        [Column("address")]
        public string? Address { get; set; }
        [Required]
        [Column("commission")]
        public double? Commission { get; set; }
        [Required]
        [Column("salary")]
        public double? Salary { get; set; }
        [Required]
        [Column("user_id")]
        public int? UserId { get; set; }

        public ICollection<Payroll>? Payrolls { get; set; }
        public ICollection<Request>? Requests { get; set; } 

    }
}

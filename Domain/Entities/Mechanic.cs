using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Mechanic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? SurName { get; set; }
        [Required]
        public string? Phone { get; set; }
        [Required]
        public string? Role { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public double? Commission { get; set; }
        [Required]
        public double? Salary { get; set; }
        [Required]
        public int? UserId { get; set; }

        public ICollection<Payroll>? Payrolls { get; set; }
        public ICollection<Request>? Requests { get; set; } 

    }
}

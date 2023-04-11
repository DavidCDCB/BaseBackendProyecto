using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Payroll
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public DateTime? StartDate { get; set; }
        [Required]
        public DateTime? EndDate { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public double? Accruals { get; set; }
        [Required]
        public double? Deductions { get; set; }
        [Required]
        public double? Settlement { get; set; }

        
        public ICollection<Mechanic>? Mechanic { get; set; }

        //public ICollection<Recepcionist>? Recepcionist { get; set; }

    }
}

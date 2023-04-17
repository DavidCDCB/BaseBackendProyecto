using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("payrolls")]
    public class Payroll
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("star_date")]
        public DateOnly? StarDate { get; set; }
        [Required]
        [Column("end_date")]
        public DateOnly? EndDate { get; set; }
        [Required]
        [Column("description")]
        public string? Description { get; set; }
        [Required]
        [Column("accruals")]
        public double? Accruals { get; set; }
        [Required]
        [Column("deductions")]
        public double? Deductions { get; set; }
        [Required]
        [Column("settlement")]
        public double? Settlement { get; set; }

        
        public ICollection<Mechanic>? Mechanics { get; set; }

        //public ICollection<Recepcionist>? Recepcionist { get; set; }

    }
}

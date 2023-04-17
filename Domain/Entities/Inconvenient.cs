using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Inconvenient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public DateOnly? DateAct { get; set; }
        [Required]
        public string? State { get; set; }
        [Required]
        public int? DaysDelay { get; set; }
        [Required]
        public int ServiceRequesedId { get; set; }
        [Required]
        public bool Seen { get; set; }
        [Required]
        public string? Description { get; set; }
        public int? RequestID { get; set; }
        public Request? Request { get; set; }

    }
}

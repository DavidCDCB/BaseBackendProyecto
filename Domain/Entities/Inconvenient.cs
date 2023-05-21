using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("inconvenients")]
    public class Inconvenient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("date_act")]
        public DateOnly? DateAct { get; set; }
        [Required]
        [Column("state")]
        public string? State { get; set; }
        [Required]
        [Column("days_delay")]
        public int? DaysDelay { get; set; }
        [Required]
        [Column("service_request_id")]
        public int ServiceRequesedId { get; set; }
        [Required]
        [Column("seen")]
        public bool Seen { get; set; }
        [Required]
        [Column("description")]
        public string? Description { get; set; }
        [Column("request_id")]
        public int? RequestID { get; set; }
        public Request? Request { get; set; }

    }
}

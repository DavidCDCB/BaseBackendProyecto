using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
  [Table("requests")]
  public class Request
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }
    [Required]
    [Column("start_date")]
    public DateOnly? StarDate { get; set; }
    [Required]
    [Column("end_date")]
    public DateOnly? EndDate { get; set; }
    [DefaultValue("Activo")]
    [Required]
    [Column("state")]
    public string? State { get; set; }
    [Column("client_id")]
    public int? ClientId { get; set; }
    public Client? Client { get; set; }
    [Column("service_id")]
    public int? ServiceId { get; set; }

    public Service? Service { get; set; }
    public ICollection<Inconvenient>? Inconvenients { get; set; }
    public ICollection<Mechanic>? Mechanics { get; set; }
  }
}

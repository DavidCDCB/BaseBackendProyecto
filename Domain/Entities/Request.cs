using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
  public class Request
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public DateOnly? StarDate { get; set; }
    [Required]
    public DateOnly? EndDate { get; set; }
    [DefaultValue("Activo")]
    [Required]
    public string? State { get; set; }

    public int? ClientId { get; set; }
    public Client? Client { get; set; }

    public int? ServiceId { get; set; }
    public Service? Service { get; set; }
  }
}

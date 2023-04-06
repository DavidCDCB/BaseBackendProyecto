using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
  public class Client
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Surname { get; set; }
    [Required]
    public string? Phone { get; set; }
    [Required]
    public string? Type { get; set; }
    [Required]
    public string? Email { get; set; }
    [Required]
    public string? Address { get; set; }


    public ICollection<Vehicle>? Vehicles { get; set; }

    public ICollection<Request>? Requests { get; set; }
  }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
  public class Vehicle
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public string? Plate { get; set; }
    [Required]
    public string? Model { get; set; }
    [Required]
    public string? Year { get; set; }
    public string? Description { get; set; }
    [Required]
    public string? Color { get; set; }


    public int? ClientId { get; set; }
    public Client? Client { get; set; }
  }
}

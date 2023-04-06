using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
  public class Service
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }
    [Required]
    public double? Price { get; set; }
    [Required]
    public string? Description { get; set; }
    [Required]
    public string? Category { get; set; }

    public ICollection<Request>? Requests { get; set; }
  }
}

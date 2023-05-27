using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
  [Table("clients")]
  public class Client
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }
    [Required]
    [Column("name")]
    public string? Name { get; set; }
    [Required]
    [Column("surname")]
    public string? Surname { get; set; }
    [Required]
    [Column("phone")]
    public string? Phone { get; set; }
    [Required]
    [Column("type")]
    public string? Type { get; set; }
    [Required]
    [Column("email")]
    public string? Email { get; set; }
    [Required]
    [Column("address")]
    public string? Address { get; set; }
    public ICollection<Vehicle>? Vehicles { get; set; }

    public ICollection<Request>? Requests { get; set; }
  }
}

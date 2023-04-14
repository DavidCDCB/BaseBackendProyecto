using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
  [Table("vehicles")]
  public class Vehicle
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }
    [Required]
    [Column("plate")]
    public string? Plate { get; set; }
    [Required]
    [Column("model")]
    public string? Model { get; set; }
    [Required]
    [Column("year")]
    public string? Year { get; set; }
    [Column("description")]
    public string? Description { get; set; }
    [Required]
    [Column("color")]
    public string? Color { get; set; }

    [Column("client_id")]
    public int? ClientId { get; set; }
    public Client? Client { get; set; }
  }
}

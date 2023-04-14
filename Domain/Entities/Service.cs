using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
  [Table("services")]
  public class Service
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }
    [Required]
    [Column("name")]
    public string? Name { get; set; }
    [Required]
    [Column("price")]
    public double? Price { get; set; }
    [Required]
    [Column("description")]
    public string? Description { get; set; }
    [Required]
    [Column("category")]
    public string? Category { get; set; }

    public ICollection<Request>? Requests { get; set; }
  }
}

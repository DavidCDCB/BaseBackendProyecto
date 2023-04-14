using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
  [Table("suppliers")]
  public class Supplier
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }
    [Required]
    [Column("nit")]
    public string? Nit { get; set; }
    [Required]
    [Column("name")]
    public string? Name { get; set; }
    [Required]
    [Column("company")]
    public string? Company { get; set; }
    [Required]
    [Column("surname")]
    public string? SurName { get; set; }
    [Required]
    [Column("phone")]
    public string? Phone { get; set; }
    [Required]
    [Column("email")]
    public string? Email { get; set; }
    [Required]
    [Column("address")]
    public string? Address { get; set; }

    // Compras ...
  }
}

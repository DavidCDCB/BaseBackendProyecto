using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// https://www.entityframeworktutorial.net/code-first/column-dataannotations-attribute-in-code-first.aspx
namespace Domain.Entities.Base
{
  [Table("users")]
  public class User
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }
    [Required]
    [Column("full_name")]
    public string FullName { get; set; }
    [Required]
    [Column("email")]
    public string Email { get; set; }
    [Required]
    [Column("phone")]
    public long Phone { get; set; }

    public ICollection<Course>? Courses { get; set; }
  }
}

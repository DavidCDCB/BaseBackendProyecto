using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// https://www.entityframeworktutorial.net/code-first/column-dataannotations-attribute-in-code-first.aspx
namespace Domain.Entities
{
  public class User
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public string FullName { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public long Phone { get; set; }

    public ICollection<Course>? Courses { get; set; }
  }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// https://www.entityframeworktutorial.net/code-first/column-dataannotations-attribute-in-code-first.aspx
namespace NewProtoNet.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
    }
}

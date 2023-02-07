using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Level { get; set; }
        [Required]
        public string Description { get; set; }

        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        public ICollection<User> Users { get; set; }
    }
}

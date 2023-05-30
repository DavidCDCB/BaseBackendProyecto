﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("receptionists")]
    public class Receptionist
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
        [Column("address")]
        public string? Address { get; set; }
        [Required]
        [Column("salary")]
        public float? Salary { get; set; }
        [Required]
        [Column("email")]
        public string? Email { get; set; }

        [Column("user_id")]
        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
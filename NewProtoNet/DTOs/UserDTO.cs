using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServer.DTOs
{
    public class UserDTO
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
    }
}

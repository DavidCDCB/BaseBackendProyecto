using Domain.Entities;

namespace NewProtoNet.DTOs
{
    public class UserDTO
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public ICollection<Report> Courses { get; set; }
    }
}

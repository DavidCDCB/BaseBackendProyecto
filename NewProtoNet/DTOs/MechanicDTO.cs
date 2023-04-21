using Domain.Entities;

namespace RestServer.DTOs
{
    public class MechanicDTO
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public double Commission { get; set; }
        public double Salary { get; set; }
        public int UserId { get; set; }
        //public ICollection<Payroll> Payrolls { get; set; }
        //public ICollection<Request> Requests { get; set; }
    }
}

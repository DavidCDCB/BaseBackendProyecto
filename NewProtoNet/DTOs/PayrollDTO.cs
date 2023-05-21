using Domain.Entities;
using Domain.Entities.Base;

namespace RestServer.DTOs
{
    public class PayrollDTO
    {
        public DateOnly? StarDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public string? Description { get; set; }
        public double? Accruals { get; set; }
        public double? Deductions { get; set; }
        public double? Settlement { get; set; }
        //public ICollection<Mechanic>? Mechanics { get; set; }
    }
}

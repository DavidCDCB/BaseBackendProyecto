using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServer.DTOs
{
    public class PayrollMechanicsDTO
    {
        public int idPayroll { get; set; }
        public double deductions { get; set; }
        public List<Mechanic>? mechanics { get; set; }

    }
}

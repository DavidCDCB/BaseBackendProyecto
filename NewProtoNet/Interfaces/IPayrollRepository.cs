using Domain.Entities;
using RestServer.DTOs;

namespace RestServer.Interfaces
{
    public interface IPayrollRepository
    {
        Task<List<Payroll>> GetPayrolls();
        Task<Payroll> GetPayroll(int id);
        Task<Payroll> PostPayroll(PayrollDTO payroll);
        Task<Payroll> UpdatePayroll(int id, PayrollDTO payroll);
        Task<Payroll> DeletePayroll(int id);
        List<Payroll> SeedPayrolls(int size);
        Task<List<Payroll>> GetByPage(int page);
        Task<Payroll> updatePayrollMechanics(PayrollMechanicsDTO payrollMechanic);

    }
}

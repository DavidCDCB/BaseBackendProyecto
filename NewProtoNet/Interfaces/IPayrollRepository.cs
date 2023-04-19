using Domain.Entities;
using Domain.Entities.Base;
using NewProtoNet.DTOs;

namespace NewProtoNet.Interfaces
{
    public interface IPayrollRepository
    {
        Task<List<Payroll>> GetPayrolls();
        Task<Payroll> GetPayroll(int id);
        Task<Payroll> PostPayroll(PayrollDTO payroll);
        Task<Payroll> UpdatePayroll(int id, PayrollDTO payroll);
        Task<Payroll> DeletePayroll(int id);
        List<Payroll> SeedPayrolls(int size);
    }
}

using NewProtoNet.Data;
using NewProtoNet.Interfaces;
using NewProtoNet.DTOs;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Domain.Entities.Base;
using Domain.Entities;

// La lógica de negocio debe estar en la capa de aplicacion sin usar el context

namespace NewProtoNet.Repositories
{
    public class PayrollRepository : IPayrollRepository
    {
        private readonly BaseDbContext dbContext;

        public PayrollRepository(BaseDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        List<Payroll> IPayrollRepository.SeedPayrolls(int size)
        {
            int ids = 1;
            Faker<Payroll> fakeData = new Faker<Payroll>()
                .RuleFor(m => m.Id, f => ids++)
                      .RuleFor(m => m.StarDate, f => DateOnly.FromDateTime(f.Date.Past()))
                      .RuleFor(m => m.EndDate, f => DateOnly.FromDateTime(f.Date.Past()))
                      .RuleFor(m => m.Description, f => f.Name.JobDescriptor())
                      .RuleFor(m => m.Accruals, f => (double)f.Finance.Amount())
                      .RuleFor(m => m.Deductions, f => (double)f.Finance.Amount())
                      .RuleFor(m => m.Settlement, f => (double)f.Finance.Amount());

            this.dbContext.RemoveRange(dbContext.Payrolls);

            List<Payroll> seedData = fakeData.Generate(size);

            this.dbContext.AddRange(seedData);
            this.dbContext.SaveChanges();
            return seedData;
        }

        async Task<List<Payroll>> IPayrollRepository.GetPayrolls()
        {
            return await this.dbContext.Payrolls!.ToListAsync();
        }

        async Task<Payroll?> IPayrollRepository.GetPayroll(int id)
        {
            Console.WriteLine("OKss");
            Payroll? payroll = await dbContext.Payrolls!.FirstOrDefaultAsync(m => m.Id == id);
            return (payroll != null) ? payroll : null;
        }

        async Task<Payroll> IPayrollRepository.PostPayroll(PayrollDTO payroll)
        {
            Payroll Payroll = new Payroll()
            {
                StarDate = payroll.StarDate,
                EndDate = payroll.EndDate,
                Description = payroll.Description,
                Accruals = payroll.Accruals,
                Deductions = payroll.Deductions,
                Settlement = payroll.Settlement
            };

            await this.dbContext.Payrolls!.AddAsync(Payroll);
            await this.dbContext.SaveChangesAsync();

            return Payroll;
        }

        async Task<Payroll> IPayrollRepository.UpdatePayroll(int id, PayrollDTO payroll)
        {
            Payroll? encontrado = await this.dbContext.Payrolls!.FindAsync(id);
            if (encontrado == null)
            {
                return encontrado;
            }

            encontrado.StarDate = payroll.StarDate;
            encontrado.EndDate = payroll.EndDate;
            encontrado.Description = payroll.Description;
            encontrado.Accruals = payroll.Accruals;
            encontrado.Deductions = payroll.Deductions;
            encontrado.Settlement = payroll.Settlement;
            await this.dbContext.SaveChangesAsync();

            return encontrado;
        }

        async Task<Payroll> IPayrollRepository.DeletePayroll(int id)
        {
            Payroll? encontrado = await dbContext.Payrolls!.FindAsync(id);
            if (encontrado != null)
            {
                this.dbContext.Remove(encontrado);
                this.dbContext.SaveChanges();
            }
            return encontrado;
        }

    }
}

using Bogus;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using RestServer.Data;
using RestServer.DTOs;
using RestServer.Interfaces;

// La lógica de negocio debe estar en la capa de aplicacion sin usar el context

namespace RestServer.Repositories
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
            Payroll? find = await this.dbContext.Payrolls!.FindAsync(id);
            if (find == null)
            {
                return find;
            }

            find.StarDate = payroll.StarDate;
            find.EndDate = payroll.EndDate;
            find.Description = payroll.Description;
            find.Accruals = payroll.Accruals;
            find.Deductions = payroll.Deductions;
            find.Settlement = payroll.Settlement;
            await this.dbContext.SaveChangesAsync();

            return find;
        }

        async Task<Payroll> IPayrollRepository.DeletePayroll(int id)
        {
            Payroll? find = await dbContext.Payrolls!.FindAsync(id);
            if (find != null)
            {
                this.dbContext.Remove(find);
                this.dbContext.SaveChanges();
            }
            return find;
        }
        async Task<List<Payroll>> IPayrollRepository.GetByPage(int page)
        {
            const int pageSize = 10;
            List<Payroll> payrolls = await this.dbContext.Payrolls!.ToListAsync();
            int totalPages = (int)Math.Ceiling((double)payrolls.Count / pageSize);
            return (page <= totalPages) ? payrolls.Skip((page - 1) * pageSize).Take(pageSize).ToList() : new List<Payroll>();
        }

        async Task<Payroll> IPayrollRepository.updatePayrollMechanics(PayrollMechanicsDTO payrollMechanicsDTO)
        {
            Payroll payroll = await this.dbContext.Payrolls.FindAsync(payrollMechanicsDTO.idPayroll);
            if (payroll == null)
            {
                throw new Exception("Payroll not found");
            }
            if (payrollMechanicsDTO.mechanics == null || payrollMechanicsDTO.mechanics.Count == 0)
            {
                throw new Exception("Mechanics list is empty");
            }

            payroll.Accruals = await calcularAccruals(payrollMechanicsDTO.mechanics, payroll);
            payroll.Deductions = payrollMechanicsDTO.deductions;
            payroll.Settlement = payroll.Accruals - payroll.Deductions;
            payroll.Mechanics = payrollMechanicsDTO.mechanics;

            await this.dbContext.SaveChangesAsync();

            return payroll;
        }

        async Task<double> calcularAccruals(List<Mechanic> mechanics, Payroll payroll)
        {
            double accruals = 0;

            foreach (var mechanic in mechanics)
            {
                List<Request> requests = await this.dbContext.Requests
                    .Where(r => r.StarDate >= payroll.StarDate && r.EndDate <= payroll.EndDate)
                    .Where(r => r.Mechanics.Any(m => m.Id == mechanic.Id))
                    .ToListAsync();

                if (requests == null || requests.Count == 0)
                {
                    throw new Exception("Requests not found");
                }

                double mechanicSalary = 0;

                foreach (var request in requests)
                {
                    List<Service> services = await this.dbContext.Services
                        .AsNoTracking() // Desactivar el rastreo de entidades
                        .Where(s => s.Id == request.ServiceId)
                        .ToListAsync();

                    if (services == null || services.Count == 0)
                    {
                        throw new Exception("Services not found");
                    }

                    double requestSalary = services.Sum(service => service.Price ?? 0);
                    mechanicSalary += requestSalary;
                }

                Mechanic existingMechanic = await this.dbContext.Mechanics.FindAsync(mechanic.Id);
                if (existingMechanic == null)
                {
                    throw new Exception("Mechanic not found");
                }

                existingMechanic.Salary = mechanicSalary;
                accruals += mechanicSalary;
            }

            // Avoid tracking Mechanic entities again
            await this.dbContext.SaveChangesAsync();

            return accruals;
        }





    }
}

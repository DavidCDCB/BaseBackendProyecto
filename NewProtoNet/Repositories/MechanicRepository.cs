using Bogus;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NewProtoNet.Data;
using NewProtoNet.DTOs;
using NewProtoNet.Interfaces;

// La lógica de negocio debe estar en la capa de aplicacion sin usar el context

namespace NewProtoNet.Repositories
{
    public class MechanicRepository : IMechanicRepository
    {
        private readonly BaseDbContext dbContext;

        public MechanicRepository(BaseDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        List<Mechanic> IMechanicRepository.SeedMechanics(int size)
        {
            int ids = 1;
            var roles = new[] { "Master", "Junior", "Aprendiz" };
            var commision = new[] { 20, 30, 40 };
            Faker<Mechanic> fakeData = new Faker<Mechanic>()
                .RuleFor(m => m.Id, f => ids++)
                    .RuleFor(m => m.Name, f => f.Person.FirstName)
                    .RuleFor(m => m.SurName, f => f.Person.LastName)
                    .RuleFor(m => m.Phone, f => f.Person.Phone)
                    .RuleFor(m => m.Role, f => f.PickRandom(roles))
                    .RuleFor(m => m.Email, f => f.Person.Email)
                    .RuleFor(m => m.Address, f => f.Person.Address.Street)
                    .RuleFor(m => m.Commission, f => f.PickRandom(commision))
                    .RuleFor(m => m.Salary, f => (double)f.Finance.Amount())
                    .RuleFor(m => m.UserId, f => f.Random.Number(1, 99));

            this.dbContext.RemoveRange(dbContext.Mechanics);

            List<Mechanic> seedData = fakeData.Generate(size);

            this.dbContext.AddRange(seedData);
            this.dbContext.SaveChanges();
            return seedData;
        }

        async Task<List<Mechanic>> IMechanicRepository.GetMechanics()
        {
            return await this.dbContext.Mechanics!.ToListAsync();
        }

        async Task<Mechanic?> IMechanicRepository.GetMechanic(int id)
        {
            Console.WriteLine("OKss");
            Mechanic? mechanic = await dbContext.Mechanics!.FirstOrDefaultAsync(m => m.Id == id);
            return (mechanic != null) ? mechanic : null;
        }

        async Task<Mechanic> IMechanicRepository.PostMechanic(MechanicDTO mechanic)
        {
            Mechanic newMechanic = new Mechanic()
            {
                Name = mechanic.Name,
                SurName = mechanic.SurName,
                Phone = mechanic.Phone,
                Role = mechanic.Role,
                Email = mechanic.Email,
                Address = mechanic.Address,
                Commission = mechanic.Commission,
                Salary = mechanic.Salary,
                UserId = mechanic.UserId,
                Payrolls = mechanic.Payrolls,
                Requests = mechanic.Requests
            };

            await this.dbContext.Mechanics!.AddAsync(newMechanic);
            await this.dbContext.SaveChangesAsync();

            return newMechanic;
        }

        async Task<Mechanic> IMechanicRepository.UpdateMechanic(int id, MechanicDTO mechanic)
        {
            Mechanic? encontrado = await this.dbContext.Mechanics!.FindAsync(id);
            if (encontrado == null)
            {
                return encontrado;
            }

            encontrado.Name = mechanic.Name;
            encontrado.SurName = mechanic.SurName;
            encontrado.Phone = mechanic.Phone;
            encontrado.Role = mechanic.Role;
            encontrado.Email = mechanic.Email;
            encontrado.Address = mechanic.Address;
            encontrado.Commission = mechanic.Commission;
            encontrado.Salary = mechanic.Salary;
            encontrado.UserId = mechanic.UserId;
            encontrado.Payrolls = mechanic.Payrolls;
            encontrado.Requests = mechanic.Requests;
            await this.dbContext.SaveChangesAsync();

            return encontrado;
        }

        async Task<Mechanic> IMechanicRepository.DeleteMechanic(int id)
        {
            Mechanic? encontrado = await dbContext.Mechanics!.FindAsync(id);
            if (encontrado != null)
            {
                this.dbContext.Remove(encontrado);
                this.dbContext.SaveChanges();
            }
            return encontrado;
        }

    }
}

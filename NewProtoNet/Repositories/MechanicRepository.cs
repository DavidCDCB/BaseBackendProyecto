using Bogus;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using RestServer.Data;
using RestServer.DTOs;
using RestServer.Interfaces;

// La lógica de negocio debe estar en la capa de aplicacion sin usar el context

namespace RestServer.Repositories
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
                //Payrolls = mechanic.Payrolls,
                //Requests = mechanic.Requests
            };

            await this.dbContext.Mechanics!.AddAsync(newMechanic);
            await this.dbContext.SaveChangesAsync();

            return newMechanic;
        }

        async Task<Mechanic> IMechanicRepository.UpdateMechanic(int id, MechanicDTO mechanic)
        {
            Mechanic? find = await this.dbContext.Mechanics!.FindAsync(id);
            if (find == null)
            {
                return find;
            }

            find.Name = mechanic.Name;
            find.SurName = mechanic.SurName;
            find.Phone = mechanic.Phone;
            find.Role = mechanic.Role;
            find.Email = mechanic.Email;
            find.Address = mechanic.Address;
            find.Commission = mechanic.Commission;
            find.Salary = mechanic.Salary;
            find.UserId = mechanic.UserId;
            //find.Payrolls = mechanic.Payrolls;
            //find.Requests = mechanic.Requests;
            await this.dbContext.SaveChangesAsync();

            return find;
        }

        async Task<Mechanic> IMechanicRepository.DeleteMechanic(int id)
        {
            Mechanic? find = await dbContext.Mechanics!.FindAsync(id);
            if (find != null)
            {
                this.dbContext.Remove(find);
                this.dbContext.SaveChanges();
            }
            return find;
        }
        async Task<List<Mechanic>> IMechanicRepository.GetByPage(int page)
        {
            const int pageSize = 10;
            List<Mechanic> mechanics = await this.dbContext.Mechanics!.ToListAsync();
            int totalPages = (int)Math.Ceiling((double)mechanics.Count / pageSize);
            return (page <= totalPages) ? mechanics.Skip((page - 1) * pageSize).Take(pageSize).ToList() : new List<Mechanic>();
        }

    }
}

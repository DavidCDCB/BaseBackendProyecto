using RestServer.Data;
using RestServer.Interfaces;
using RestServer.DTOs;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

// La lógica de negocio debe estar en la capa de aplicacion sin usar el context

namespace RestServer.Repositories
{
    public class InconvenientRepository : IInconvenientRepository
    {
        private readonly BaseDbContext dbContext;

        public InconvenientRepository(BaseDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        List<Inconvenient> IInconvenientRepository.SeedInconvenients(int size)
        {
            int ids = 1;
            var states = new[] { "Mecanico", "Financiero", "Social", "Tiempo" };
            Faker<Inconvenient> fakeData = new Faker<Inconvenient>()
          .RuleFor(m => m.Id, f => ids++)
              .RuleFor(m => m.DateAct, f => DateOnly.FromDateTime(f.Date.Past()))
              .RuleFor(m => m.State, f => f.PickRandom(states))
              .RuleFor(m => m.DaysDelay, f => f.Random.Number(1, 20))
              .RuleFor(m => m.ServiceRequesedId, f => f.Random.Number(1, 99))
              .RuleFor(m => m.Seen, f => f.Random.Bool())
              .RuleFor(m => m.Description, f => f.Name.JobDescriptor())
              .RuleFor(m => m.RequestID, f => f.Random.Number(1, 99));

            this.dbContext.RemoveRange(dbContext.Inconvenients);

            List<Inconvenient> seedData = fakeData.Generate(size);

            this.dbContext.AddRange(seedData);
            this.dbContext.SaveChanges();
            return seedData;
        }

        async Task<List<Inconvenient>> IInconvenientRepository.GetInconvenients()
        {
            return await this.dbContext.Inconvenients!.ToListAsync();
        }

        async Task<Inconvenient?> IInconvenientRepository.GetInconvenient(int id)
        {
            Console.WriteLine("OKss");
            Inconvenient? inconvenient = await dbContext.Inconvenients!.FirstOrDefaultAsync(m => m.Id == id);
            return (inconvenient != null) ? inconvenient : null;
        }

        async Task<Inconvenient> IInconvenientRepository.PostInconvenient(InconvenientDTO inconvenient)
        {
            Inconvenient usuario = new Inconvenient()
            {
                DateAct = inconvenient.DateAct,
                State = inconvenient.State,
                DaysDelay = inconvenient.DaysDelay,
                ServiceRequesedId = inconvenient.ServiceRequesedId,
                Seen = inconvenient.Seen,
                Description = inconvenient.Description,
                RequestID = inconvenient.RequestID
            };

            await this.dbContext.Inconvenients!.AddAsync(usuario);
            await this.dbContext.SaveChangesAsync();

            return usuario;
        }

        async Task<Inconvenient> IInconvenientRepository.UpdateInconvenient(int id, InconvenientDTO inconvenient)
        {
            Inconvenient? find = await this.dbContext.Inconvenients!.FindAsync(id);
            if (find == null)
            {
                return find;
            }

            find.DateAct = inconvenient.DateAct;
            find.State = inconvenient.State;
            find.DaysDelay = inconvenient.DaysDelay;
            find.ServiceRequesedId = inconvenient.ServiceRequesedId;
            find.Seen = inconvenient.Seen;
            find.Description = inconvenient.Description;
            find.RequestID = inconvenient.RequestID;
            await this.dbContext.SaveChangesAsync();

            return find;
        }

        async Task<Inconvenient> IInconvenientRepository.DeleteInconvenient(int id)
        {
            Inconvenient? find = await dbContext.Inconvenients!.FindAsync(id);
            if (find != null)
            {
                this.dbContext.Remove(find);
                this.dbContext.SaveChanges();
            }
            return find;
        }

        async Task<List<Inconvenient>> IInconvenientRepository.GetByPage(int page)
        {
            const int pageSize = 10;
            List<Inconvenient> inconvenients = await this.dbContext.Inconvenients!.ToListAsync();
            int totalPages = (int)Math.Ceiling((double)inconvenients.Count / pageSize);
            return (page <= totalPages) ? inconvenients.Skip((page - 1) * pageSize).Take(pageSize).ToList() : new List<Inconvenient>();
        }
    }
}

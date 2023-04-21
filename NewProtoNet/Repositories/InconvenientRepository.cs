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
            Inconvenient? encontrado = await this.dbContext.Inconvenients!.FindAsync(id);
            if (encontrado == null)
            {
                return encontrado;
            }

            encontrado.DateAct = inconvenient.DateAct;
            encontrado.State = inconvenient.State;
            encontrado.DaysDelay = inconvenient.DaysDelay;
            encontrado.ServiceRequesedId = inconvenient.ServiceRequesedId;
            encontrado.Seen = inconvenient.Seen;
            encontrado.Description = inconvenient.Description;
            encontrado.RequestID = inconvenient.RequestID;
            await this.dbContext.SaveChangesAsync();

            return encontrado;
        }

        async Task<Inconvenient> IInconvenientRepository.DeleteInconvenient(int id)
        {
            Inconvenient? encontrado = await dbContext.Inconvenients!.FindAsync(id);
            if (encontrado != null)
            {
                this.dbContext.Remove(encontrado);
                this.dbContext.SaveChanges();
            }
            return encontrado;
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

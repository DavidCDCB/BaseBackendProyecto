using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using RestServer.Data;
using RestServer.DTOs;
using RestServer.Interfaces;
using System.Drawing.Printing;

namespace RestServer.Repositories
{
    public class RecepcionistRepository : IRecepcionistRepository
    {

        private readonly BaseDbContext dbContext;

        public RecepcionistRepository(BaseDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        async Task<List<Recepcionist>> IRecepcionistRepository.GetRecepcionists()
        {
            return await this.dbContext.Recepcionists!.ToListAsync();
        }

        async Task<Recepcionist?> IRecepcionistRepository.GetRecepcionist(int id)
        {
            Recepcionist? Recepcionist = await dbContext.Recepcionists!.FirstOrDefaultAsync(m => m.Id == id);
            return (Recepcionist != null) ? Recepcionist : null;
        }

        async Task<Recepcionist> IRecepcionistRepository.PostRecepcionist(RecepcionistDTO RecepcionistDTO)
        {
            Recepcionist Recepcionist = new Recepcionist()
            {
                Id = RecepcionistDTO.Id,
                Name = RecepcionistDTO.Name,
                Surname = RecepcionistDTO.Surname,
                Phone = RecepcionistDTO.Phone,
                Address = RecepcionistDTO.Address,
                Salary = RecepcionistDTO.Salary,
                Email = RecepcionistDTO.Email,
            };

            await this.dbContext.Recepcionists!.AddAsync(Recepcionist);
            await this.dbContext.SaveChangesAsync();

            return Recepcionist;
        }

        async Task<Recepcionist?> IRecepcionistRepository.UpdateRecepcionist(int id, RecepcionistDTO Recepcionist)
        {
            Recepcionist? find = await this.dbContext.Recepcionists!.FindAsync(id);
            if (find == null)
            {
                return find;
            }

            find.Id = Recepcionist.Id;
            find.Name = Recepcionist.Name;
            find.Surname = Recepcionist.Surname;
            find.Phone = Recepcionist.Phone;
            find.Address = Recepcionist.Address;
            find.Salary = Recepcionist.Salary;
            find.Email = Recepcionist.Email;

            await this.dbContext.SaveChangesAsync();

            return find;
        }

        async Task<Recepcionist?> IRecepcionistRepository.DeleteRecepcionist(int id)
        {
            Recepcionist? find = await dbContext.Recepcionists!.FindAsync(id);
            if (find != null)
            {
                this.dbContext.Remove(find);
                this.dbContext.SaveChanges();
            }
            return find!;
        }

        async Task<List<Recepcionist>> IRecepcionistRepository.GetByPage(int page)
        {
            const int pageSize = 10;
            List<Recepcionist> Recepcionists = await this.dbContext.Recepcionists!.ToListAsync();
            int totalPages = (int)Math.Ceiling((double)Recepcionists.Count / pageSize);
            return (page <= totalPages) ? Recepcionists.Skip((page - 1) * pageSize).Take(pageSize).ToList() : new List<Recepcionist>();
        }
    }
}
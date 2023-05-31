using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using RestServer.Data;
using RestServer.DTOs;
using RestServer.Interfaces;
using System.Drawing.Printing;

namespace RestServer.Repositories
{
    public class ReceptionistRepository : IReceptionistRepository
    {

        private readonly BaseDbContext dbContext;

        public ReceptionistRepository(BaseDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        async Task<List<Receptionist>> IReceptionistRepository.GetReceptionists()
        {
            return await this.dbContext.Receptionists!.ToListAsync();
        }

        async Task<List<User>> IReceptionistRepository.GetReceptionistsUsers()
        {
            return await this.dbContext.Users!.Where(x => x.role == "Receptionist").ToListAsync();
        }

        async Task<Receptionist?> IReceptionistRepository.GetReceptionist(int id)
        {
            Receptionist? Receptionist = await dbContext.Receptionists!.FirstOrDefaultAsync(m => m.Id == id);
            return (Receptionist != null) ? Receptionist : null;
        }

        async Task<Receptionist> IReceptionistRepository.PostReceptionist(ReceptionistDTO ReceptionistDTO)
        {
            User? findUser = await this.dbContext.Users!.FindAsync(ReceptionistDTO.UserId);
            if (findUser == null || (findUser.role != "Receptionist"))
            {
                throw new KeyNotFoundException("El usuario no existe o no tiene un rol de Recepcionista asignado");
            }

            Receptionist Receptionist = new Receptionist()
            {
                Name = ReceptionistDTO.Name,
                Surname = ReceptionistDTO.Surname,
                Phone = ReceptionistDTO.Phone,
                Address = ReceptionistDTO.Address,
                Salary = ReceptionistDTO.Salary,
                Email = ReceptionistDTO.Email,
                UserId = ReceptionistDTO.UserId,
            };

            await this.dbContext.Receptionists!.AddAsync(Receptionist);
            await this.dbContext.SaveChangesAsync();

            return Receptionist;
        }

        async Task<Receptionist?> IReceptionistRepository.UpdateReceptionist(int id, ReceptionistDTO Receptionist)
        {
            Receptionist? find = await this.dbContext.Receptionists!.FindAsync(id);
            if (find == null)
            {
                return find;
            }

            User? findUser = await this.dbContext.Users!.FindAsync(Receptionist.UserId);
            if (findUser == null || (findUser.role != "Receptionist"))
            {
                throw new KeyNotFoundException("El usuario no existe o no tiene un rol de Recepcionista asignado");
            }

            find.Name = Receptionist.Name;
            find.Surname = Receptionist.Surname;
            find.Phone = Receptionist.Phone;
            find.Address = Receptionist.Address;
            find.Salary = Receptionist.Salary;
            find.Email = Receptionist.Email;
            find.UserId = Receptionist.UserId;

            await this.dbContext.SaveChangesAsync();

            return find;
        }

        async Task<Receptionist?> IReceptionistRepository.DeleteReceptionist(int id)
        {
            Receptionist? find = await dbContext.Receptionists!.FindAsync(id);
            if (find != null)
            {
                this.dbContext.Remove(find);
                this.dbContext.SaveChanges();
            }
            return find!;
        }

        async Task<List<Receptionist>> IReceptionistRepository.GetByPage(int page)
        {
            const int pageSize = 10;
            List<Receptionist> Receptionists = await this.dbContext.Receptionists!.ToListAsync();
            int totalPages = (int)Math.Ceiling((double)Receptionists.Count / pageSize);
            return (page <= totalPages) ? Receptionists.Skip((page - 1) * pageSize).Take(pageSize).ToList() : new List<Receptionist>();
        }
    }
}
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using RestServer.Data;
using RestServer.DTOs;
using RestServer.Interfaces;
using System.Drawing.Printing;

namespace RestServer.Repositories
{
    public class AdministratorRepository : IAdministratorRepository
    {

        private readonly BaseDbContext dbContext;

        public AdministratorRepository(BaseDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        async Task<List<Administrator>> IAdministratorRepository.GetAdministrators()
        {
            return await this.dbContext.Administrators!.ToListAsync();
        }

        async Task<Administrator?> IAdministratorRepository.GetAdministrator(int id)
        {
            Administrator? Administrator = await dbContext.Administrators!.FirstOrDefaultAsync(m => m.Id == id);
            return (Administrator != null) ? Administrator : null;
        }

        async Task<Administrator> IAdministratorRepository.PostAdministrator(AdministratorDTO AdministratorDTO)
        {
            Administrator Administrator = new Administrator()
            {
                Name = AdministratorDTO.Name,
                Surname = AdministratorDTO.Surname,
                Phone = AdministratorDTO.Phone,
                UserId = AdministratorDTO.UserId,
            };

            await this.dbContext.Administrators!.AddAsync(Administrator);
            await this.dbContext.SaveChangesAsync();

            return Administrator;
        }

        async Task<Administrator?> IAdministratorRepository.UpdateAdministrator(int id, AdministratorDTO Administrator)
        {
            Administrator? encontrado = await this.dbContext.Administrators!.FindAsync(id);
            if (encontrado == null)
            {
                return encontrado;
            }

            encontrado.Name = Administrator.Name;
            encontrado.Surname = Administrator.Surname;
            encontrado.Phone = Administrator.Phone;
            encontrado.UserId = Administrator.UserId;
            await this.dbContext.SaveChangesAsync();

            return encontrado;
        }

        async Task<Administrator?> IAdministratorRepository.DeleteAdministrator(int id)
        {
            Administrator? encontrado = await dbContext.Administrators!.FindAsync(id);
            if (encontrado != null)
            {
                this.dbContext.Remove(encontrado);
                this.dbContext.SaveChanges();
            }
            return encontrado!;
        }

        async Task<List<Administrator>> IAdministratorRepository.GetByPage(int page)
        {
            const int pageSize = 10;
            List<Administrator> Administrators = await this.dbContext.Administrators!.ToListAsync();
            int totalPages = (int)Math.Ceiling((double)Administrators.Count / pageSize);
            return (page <= totalPages) ? Administrators.Skip((page - 1) * pageSize).Take(pageSize).ToList() : new List<Administrator>();
        }
    }
}
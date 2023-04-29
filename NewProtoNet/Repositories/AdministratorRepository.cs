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
            Administrator? find = await this.dbContext.Administrators!.FindAsync(id);
            if (find == null)
            {
                return find;
            }
            find.Name = Administrator.Name;
            find.Surname = Administrator.Surname;
            find.Phone = Administrator.Phone;
            find.UserId = Administrator.UserId;
            await this.dbContext.SaveChangesAsync();

            return find;
        }

        async Task<Administrator?> IAdministratorRepository.DeleteAdministrator(int id)
        {
            Administrator? find = await dbContext.Administrators!.FindAsync(id);
            if (find != null)
            {
                this.dbContext.Remove(find);
                this.dbContext.SaveChanges();
            }
            return find!;
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
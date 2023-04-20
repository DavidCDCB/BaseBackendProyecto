using Domain.Entities;
using RestServer.DTOs;

namespace RestServer.Interfaces
{
    public interface IAdministratorRepository
    {
        Task<List<Administrator>> GetAdministrators();
        Task<List<Administrator>> GetByPage(int page);

        Task<Administrator> GetAdministrator(int id);
        Task<Administrator> PostAdministrator(AdministratorDTO Administrator);
        Task<Administrator> UpdateAdministrator(int id, AdministratorDTO Administrator);
        Task<Administrator> DeleteAdministrator(int id);
    }
}

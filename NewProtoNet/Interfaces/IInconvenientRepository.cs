using Domain.Entities;
using RestServer.DTOs;

namespace RestServer.Interfaces
{
    public interface IInconvenientRepository
    {
        Task<List<Inconvenient>> GetInconvenients();
        Task<Inconvenient> GetInconvenient(int id);
        Task<Inconvenient> PostInconvenient(InconvenientDTO inconvenient);
        Task<Inconvenient> UpdateInconvenient(int id, InconvenientDTO inconvenient);
        Task<Inconvenient> DeleteInconvenient(int id);
        List<Inconvenient> SeedInconvenients(int size);
        Task<List<Inconvenient>> GetByPage(int page);
    }
}

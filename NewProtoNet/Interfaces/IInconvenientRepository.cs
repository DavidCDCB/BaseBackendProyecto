using Domain.Entities;
using NewProtoNet.DTOs;

namespace NewProtoNet.Interfaces
{
    public interface IInconvenientRepository
  {
    Task<List<Inconvenient>> GetInconvenients();
    Task<Inconvenient> GetInconvenient(int id);
    Task<Inconvenient> PostInconvenient(InconvenientDTO inconvenient);
    Task<Inconvenient> UpdateInconvenient(int id, InconvenientDTO inconvenient);
    Task<Inconvenient> DeleteInconvenient(int id);
    List<Inconvenient> SeedInconvenients(int size);
  }
}

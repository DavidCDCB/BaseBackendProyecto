using Domain.Entities;
using RestServer.DTOs;

namespace RestServer.Interfaces
{
  public interface IClientRepository
  {
    Task<List<Client>> GetClients();
    Task<Client?> GetClient(int id);
    Task<Client> PostClient(ClientDTO user);
    Task<Client?> UpdateClient(int id, ClientDTO user);
    Task<Client?> DeleteClient(int id);
  }
}

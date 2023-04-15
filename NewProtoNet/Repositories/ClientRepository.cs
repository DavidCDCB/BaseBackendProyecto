using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using RestServer.Data;
using RestServer.DTOs;
using RestServer.Interfaces;

namespace RestServer.Repositories
{
  public class ClientRepository : IClientRepository
  {
    private readonly BaseDbContext dbContext;

    public ClientRepository(BaseDbContext dbContext)
    {
      this.dbContext = dbContext;
    }

    async Task<List<Client>> IClientRepository.GetClients()
    {
      return await this.dbContext.Clients!.ToListAsync();
    }

    async Task<Client?> IClientRepository.GetClient(int id)
    {
      Client? Client = await dbContext.Clients!.FirstOrDefaultAsync(m => m.Id == id);
      return (Client != null) ? Client : null;
    }

    async Task<Client> IClientRepository.PostClient(ClientDTO client)
    {
      Client cliente = new Client()
      {
        Name = client.Name,
        Surname = client.Surname,
        Phone = client.Phone,
        Type = client.Type,
        Email = client.Email,
        Address = client.Address,
      };

      await this.dbContext.Clients!.AddAsync(cliente);
      await this.dbContext.SaveChangesAsync();

      return cliente;
    }

    async Task<Client?> IClientRepository.UpdateClient(int id, ClientDTO client)
    {
      Client? encontrado = await this.dbContext.Clients!.FindAsync(id);
      if (encontrado == null)
      {
        return encontrado;
      }

      encontrado.Name = client.Name;
      encontrado.Surname = client.Surname;
      encontrado.Phone = client.Phone;
      encontrado.Type = client.Type;
      encontrado.Email = client.Email;
      encontrado.Address = client.Address;

      await this.dbContext.SaveChangesAsync();

      return encontrado;
    }

    async Task<Client?> IClientRepository.DeleteClient(int id)
    {
      Client? encontrado = await dbContext.Clients!.FindAsync(id);
      if (encontrado != null)
      {
        this.dbContext.Remove(encontrado);
        this.dbContext.SaveChanges();
      }
      return encontrado;
    }
  }
}

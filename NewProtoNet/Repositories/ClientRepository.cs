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
                UserId = client.UserId
            };

            await this.dbContext.Clients!.AddAsync(cliente);
            await this.dbContext.SaveChangesAsync();

            return cliente;
        }

        async Task<Client?> IClientRepository.UpdateClient(int id, ClientDTO client)
        {
            Client? find = await this.dbContext.Clients!.FindAsync(id);
            if (find == null)
            {
                return find;
            }

            find.Name = client.Name;
            find.Surname = client.Surname;
            find.Phone = client.Phone;
            find.Type = client.Type;
            find.Email = client.Email;
            find.Address = client.Address;
            find.UserId = client.UserId;

            await this.dbContext.SaveChangesAsync();

            return find;
        }

        async Task<Client?> IClientRepository.DeleteClient(int id)
        {
            Client? find = await dbContext.Clients!.FindAsync(id);
            if (find != null)
            {
                this.dbContext.Remove(find);
                this.dbContext.SaveChanges();
            }
            return find;
        }

        async Task<List<Client>> IClientRepository.GetByPage(int page)
        {
            const int pageSize = 10;
            List<Client> clients = await this.dbContext.Clients!.ToListAsync();
            int totalPages = (int)Math.Ceiling((double)clients.Count / pageSize);
            return (page <= totalPages) ? clients.Skip((page - 1) * pageSize).Take(pageSize).ToList() : new List<Client>();
        }
    }
}

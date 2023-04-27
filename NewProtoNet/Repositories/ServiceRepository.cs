using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using RestServer.Data;
using RestServer.DTOs;
using RestServer.Interfaces;

namespace RestServer.Repositories
{
  public class ServiceRepository : IServiceRepository
  {
    private readonly BaseDbContext dbContext;

    public ServiceRepository(BaseDbContext dbContext)
    {
      this.dbContext = dbContext;
    }

    async Task<List<Service>> IServiceRepository.GetServices()
    {
      return await this.dbContext.Services!.ToListAsync();
    }

    async Task<Service?> IServiceRepository.GetService(int id)
    {
      Service? Service = await dbContext.Services!.FirstOrDefaultAsync(m => m.Id == id);
      return (Service != null) ? Service : null;
    }

    async Task<Service> IServiceRepository.PostService(ServiceDTO serviceDTO)
    {
      Service service = new Service()
      {
        Name = serviceDTO.Name,
        Price = serviceDTO.Price,
        Description = serviceDTO.Description,
        Category = serviceDTO.Category
      };

      await this.dbContext.Services!.AddAsync(service);
      await this.dbContext.SaveChangesAsync();

      return service;
    }

    async Task<Service?> IServiceRepository.UpdateService(int id, ServiceDTO Service)
    {
      Service? find = await this.dbContext.Services!.FindAsync(id);
      if (find == null)
      {
        return find;
      }

      find.Name = Service.Name;
      find.Price = Service.Price;
      find.Description = Service.Description;
      find.Category = Service.Category;

      await this.dbContext.SaveChangesAsync();

      return find;
    }

    async Task<Service?> IServiceRepository.DeleteService(int id)
    {
      Service? find = await dbContext.Services!.FindAsync(id);
      if (find != null)
      {
        this.dbContext.Remove(find);
        this.dbContext.SaveChanges();
      }
      return find;
    }

    async Task<List<Service>> IServiceRepository.GetByPage(int page)
    {
      const int pageSize = 10;
      List<Service> services = await this.dbContext.Services!.ToListAsync();
      int totalPages = (int)Math.Ceiling((double)services.Count / pageSize);
      return (page <= totalPages) ? services.Skip((page - 1) * pageSize).Take(pageSize).ToList() : new List<Service>();
    }
  }
}

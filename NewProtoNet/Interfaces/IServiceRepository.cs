using Domain.Entities;
using RestServer.DTOs;

namespace RestServer.Interfaces
{
  public interface IServiceRepository
  {
    Task<List<Service>> GetServices();
    Task<List<Service>> GetByPage(int page);
    Task<Service?> GetService(int id);
    Task<Service> PostService(ServiceDTO service);
    Task<Service?> UpdateService(int id, ServiceDTO service);
    Task<Service?> DeleteService(int id);
  }
}

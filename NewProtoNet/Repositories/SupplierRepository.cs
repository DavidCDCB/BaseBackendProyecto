using Domain.Entities;
using RestServer.Data;
using RestServer.DTOs;
using RestServer.Interfaces;

namespace RestServer.Repositories
{
  public class SupplierRepository : ISupplierRepository
  {

    private readonly BaseDbContext dbContext;

    public SupplierRepository(BaseDbContext dbContext)
    {
      this.dbContext = dbContext;
    }

    Task<List<Supplier>> ISupplierRepository.GetSuppliers()
    {
      throw new NotImplementedException();
    }

    public Task<Supplier> GetSupplier(int id)
    {
      throw new NotImplementedException();
    }

    public Task<Supplier> PostSupplier(UserDTO user)
    {
      throw new NotImplementedException();
    }

    public Task<Supplier> UpdateSupplier(int id, UserDTO user)
    {
      throw new NotImplementedException();
    }

    public Task<Supplier> DeleteSupplierr(int id)
    {
      throw new NotImplementedException();
    }

  }
}

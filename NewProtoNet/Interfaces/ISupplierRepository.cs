using Domain.Entities;
using RestServer.DTOs;

namespace RestServer.Interfaces
{
  public interface ISupplierRepository
  {
    Task<List<Supplier>> GetSuppliers();
    Task<Supplier> GetSupplier(int id);
    Task<Supplier> PostSupplier(UserDTO user);
    Task<Supplier> UpdateSupplier(int id, UserDTO user);
    Task<Supplier> DeleteSupplierr(int id);
  }
}
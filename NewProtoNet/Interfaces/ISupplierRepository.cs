using Domain.Entities;
using RestServer.DTOs;

namespace RestServer.Interfaces
{
  public interface ISupplierRepository
  {
    Task<List<Supplier>> GetSuppliers();
    Task<Supplier?> GetSupplier(int id);
    Task<Supplier> PostSupplier(SupplierDTO user);
    Task<Supplier?> UpdateSupplier(int id, SupplierDTO user);
    Task<Supplier?> DeleteSupplier(int id);
  }
}
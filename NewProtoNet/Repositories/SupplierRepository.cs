using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using RestServer.Data;
using RestServer.DTOs;
using RestServer.Interfaces;
using System.Drawing.Printing;

namespace RestServer.Repositories
{
  public class SupplierRepository : ISupplierRepository
  {

    private readonly BaseDbContext dbContext;

    public SupplierRepository(BaseDbContext dbContext)
    {
      this.dbContext = dbContext;
    }

    async Task<List<Supplier>> ISupplierRepository.GetSuppliers()
    {
      return await this.dbContext.Suppliers!.ToListAsync();
    }

    async Task<Supplier?> ISupplierRepository.GetSupplier(int id)
    {
      Supplier? supplier = await dbContext.Suppliers!.FirstOrDefaultAsync(m => m.Id == id);
      return (supplier != null) ? supplier : null;
    }

    async Task<Supplier> ISupplierRepository.PostSupplier(SupplierDTO supplierDTO)
    {
      Supplier supplier = new Supplier()
      {
        Name = supplierDTO.Name,
        SurName = supplierDTO.SurName,
        Nit = supplierDTO.Nit,
        Company = supplierDTO.Company,
        Phone = supplierDTO.Phone,
        Email = supplierDTO.Email,
        Address = supplierDTO.Address,
      };

      await this.dbContext.Suppliers!.AddAsync(supplier);
      await this.dbContext.SaveChangesAsync();

      return supplier;
    }

    async Task<Supplier?> ISupplierRepository.UpdateSupplier(int id, SupplierDTO supplier)
    {
      Supplier? encontrado = await this.dbContext.Suppliers!.FindAsync(id);
      if (encontrado == null)
      {
        return encontrado;
      }

      encontrado.Name = supplier.Name;
      encontrado.SurName = supplier.SurName;
      encontrado.Company = supplier.Company;
      encontrado.Nit = supplier.Nit;
      encontrado.Phone = supplier.Phone;
      encontrado.Email = supplier.Email;
      encontrado.Address = supplier.Address;
      await this.dbContext.SaveChangesAsync();

      return encontrado;
    }

    async Task<Supplier?> ISupplierRepository.DeleteSupplier(int id)
    {
      Supplier? encontrado = await dbContext.Suppliers!.FindAsync(id);
      if (encontrado != null)
      {
        this.dbContext.Remove(encontrado);
        this.dbContext.SaveChanges();
      }
      return encontrado!;
    }

    async Task<List<Supplier>> ISupplierRepository.GetByPage(int page)
    {
      const int pageSize = 10;
      List<Supplier> suppliers = await this.dbContext.Suppliers!.ToListAsync();
      int totalPages = (int)Math.Ceiling((double)suppliers.Count / pageSize);
      return (page <= totalPages) ? suppliers.Skip((page - 1) * pageSize).Take(pageSize).ToList() : new List<Supplier>();
    }
  }
}

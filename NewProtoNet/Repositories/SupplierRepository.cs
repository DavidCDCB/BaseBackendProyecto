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
            Supplier? find = await this.dbContext.Suppliers!.FindAsync(id);
            if (find == null)
            {
                return find;
            }

            find.Name = supplier.Name;
            find.SurName = supplier.SurName;
            find.Company = supplier.Company;
            find.Nit = supplier.Nit;
            find.Phone = supplier.Phone;
            find.Email = supplier.Email;
            find.Address = supplier.Address;
            await this.dbContext.SaveChangesAsync();

            return find;
        }

        async Task<Supplier?> ISupplierRepository.DeleteSupplier(int id)
        {
            Supplier? find = await dbContext.Suppliers!.FindAsync(id);
            if (find != null)
            {
                this.dbContext.Remove(find);
                this.dbContext.SaveChanges();
            }
            return find!;
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

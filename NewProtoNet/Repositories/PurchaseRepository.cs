using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using RestServer.Data;
using RestServer.DTOs;
using RestServer.Interfaces;
using System.Drawing.Printing;

namespace RestServer.Repositories
{
    public class PurchaseRepository : IPurchaseRepository
    {

        private readonly BaseDbContext dbContext;

        public PurchaseRepository(BaseDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        async Task<List<Purchase>> IPurchaseRepository.GetPurchases()
        {
            return await this.dbContext.Purchases!.ToListAsync();
        }

        async Task<Purchase?> IPurchaseRepository.GetPurchase(int id)
        {
            Purchase? Purchase = await dbContext.Purchases!.FirstOrDefaultAsync(m => m.Id == id);
            return (Purchase != null) ? Purchase : null;
        }

        async Task<Purchase> IPurchaseRepository.PostPurchase(PurchaseDTO PurchaseDTO)
        {
            Purchase Purchase = new Purchase()
            {
                Id = PurchaseDTO.Id,
                purchasePrice = PurchaseDTO.purchasePrice,
                salePrice = PurchaseDTO.salePrice,
                Quantity = PurchaseDTO.Quantity,
                Description = PurchaseDTO.Description,
                Code = PurchaseDTO.Code,
                datePurchase = PurchaseDTO.datePurchase,
            };

            await this.dbContext.Purchases!.AddAsync(Purchase);
            await this.dbContext.SaveChangesAsync();

            return Purchase;
        }

        async Task<Purchase?> IPurchaseRepository.UpdatePurchase(int id, PurchaseDTO Purchase)
        {
            Purchase? encontrado = await this.dbContext.Purchases!.FindAsync(id);
            if (encontrado == null)
            {
                return encontrado;
            }

            encontrado.Id = Purchase.Id;
            encontrado.purchasePrice = Purchase.purchasePrice;
            encontrado.salePrice = Purchase.salePrice;
            encontrado.Quantity = Purchase.Quantity;
            encontrado.Description = Purchase.Description;
            encontrado.Code = Purchase.Code;
            encontrado.datePurchase = Purchase.datePurchase;
            
            await this.dbContext.SaveChangesAsync();

            return encontrado;
        }

        async Task<Purchase?> IPurchaseRepository.DeletePurchase(int id)
        {
            Purchase? encontrado = await dbContext.Purchases!.FindAsync(id);
            if (encontrado != null)
            {
                this.dbContext.Remove(encontrado);
                this.dbContext.SaveChanges();
            }
            return encontrado!;
        }

        async Task<List<Purchase>> IPurchaseRepository.GetByPage(int page)
        {
            const int pageSize = 10;
            List<Purchase> Purchases = await this.dbContext.Purchases!.ToListAsync();
            int totalPages = (int)Math.Ceiling((double)Purchases.Count / pageSize);
            return (page <= totalPages) ? Purchases.Skip((page - 1) * pageSize).Take(pageSize).ToList() : new List<Purchase>();
        }
    }
}
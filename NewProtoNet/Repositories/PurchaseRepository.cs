using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using RestServer.Data;
using RestServer.DTOs;
using RestServer.Interfaces;

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
            DateTime datePurchaseConversion = DateTime.ParseExact(PurchaseDTO.datePurchase!, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);


            Purchase Purchase = new Purchase()
            {
                purchasePrice = PurchaseDTO.purchasePrice,
                salePrice = PurchaseDTO.salePrice,
                Quantity = PurchaseDTO.Quantity,
                Description = PurchaseDTO.Description,
                Code = PurchaseDTO.Code,
                datePurchase = DateOnly.FromDateTime(datePurchaseConversion),
            };

            await this.dbContext.Purchases!.AddAsync(Purchase);
            await this.dbContext.SaveChangesAsync();

            return Purchase;
        }

        async Task<Purchase?> IPurchaseRepository.UpdatePurchase(int id, PurchaseDTO PurchaseDTO)
        {
            Purchase? encontrado = await this.dbContext.Purchases!.FindAsync(id);
            if (encontrado == null)
            {
                return encontrado;
            }
            DateTime datePurchaseConversion = DateTime.ParseExact(PurchaseDTO.datePurchase!, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            encontrado.purchasePrice = PurchaseDTO.purchasePrice;
            encontrado.salePrice = PurchaseDTO.salePrice;
            encontrado.Quantity = PurchaseDTO.Quantity;
            encontrado.Description = PurchaseDTO.Description;
            encontrado.Code = PurchaseDTO.Code;
            encontrado.datePurchase = DateOnly.FromDateTime(datePurchaseConversion);
            encontrado.ProductId = PurchaseDTO.ProductId;
            encontrado.SupplierId = PurchaseDTO.SupplierId;
            
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
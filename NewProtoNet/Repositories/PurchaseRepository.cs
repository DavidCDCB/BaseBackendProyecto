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

        private PurchaseDTO MapPurchase(Purchase p)
        {

            return new PurchaseDTO
            {   
                Id = p.Id,
                purchasePrice = p.purchasePrice,
                salePrice = p.salePrice,
                Quantity = p.Quantity,
                Code = p.Code,
                Description = p.Description,
                datePurchase = p.datePurchase.ToString(),
                ProductId = p.ProductId,
                SupplierId = p.SupplierId
            };
        }

        private List<PurchaseDTO> ChangeDates(List<Purchase> purchases)
        {
            List<PurchaseDTO> purchasesDto = new List<PurchaseDTO>();
            purchases.ForEach(p =>
            {
                purchasesDto.Add(MapPurchase(p));
            });

            return purchasesDto;
        }
        public PurchaseRepository(BaseDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        async Task<List<PurchaseDTO>> IPurchaseRepository.GetPurchases()
        {
            List<Purchase> purchases = await this.dbContext.Purchases!.ToListAsync();
            return await Task.FromResult(ChangeDates(purchases));
        }

        async Task<PurchaseDTO?> IPurchaseRepository.GetPurchase(int id)
        {
            Purchase? purchase = await dbContext.Purchases!.FirstOrDefaultAsync(m => m.Id == id);
            return (purchase != null) ? MapPurchase(purchase) : null;
        }

        async Task<PurchaseDTO> IPurchaseRepository.PostPurchase(PurchaseDTO purchaseDTO)
        {
            Product? findProduct = await this.dbContext.Products!.FindAsync(purchaseDTO.ProductId);
            if (findProduct == null)
            {
                throw new KeyNotFoundException("El producto no existe");
            }

            Supplier? findSupplier = await this.dbContext.Suppliers!.FindAsync(purchaseDTO.SupplierId);
            if (findSupplier == null)
            {
                throw new KeyNotFoundException("El proveedor no existe");
            }

            DateTime postDatePurchase = DateTime.ParseExact(purchaseDTO.datePurchase!, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            Purchase purchase = new Purchase()
            {   
                purchasePrice = purchaseDTO.purchasePrice,
                salePrice = purchaseDTO.salePrice,
                Quantity = purchaseDTO.Quantity,
                Code = purchaseDTO.Code,
                Description = purchaseDTO.Description,
                datePurchase = DateOnly.FromDateTime(postDatePurchase),
                ProductId = purchaseDTO.ProductId,
                SupplierId = purchaseDTO.SupplierId
            };
            await ModifyProductAsync(purchase);

            await this.dbContext.Purchases!.AddAsync(purchase);
            await this.dbContext.SaveChangesAsync();

            return MapPurchase(purchase);
        }

        async Task<PurchaseDTO?> IPurchaseRepository.UpdatePurchase(int id, PurchaseDTO purchaseDTO)
        {
            Purchase? find = await this.dbContext.Purchases!.FindAsync(id);
            if (find == null)
            {
                return null;
            }

            Product? findProduct = await this.dbContext.Products!.FindAsync(purchaseDTO.ProductId);
            if (findProduct == null)
            {
                throw new KeyNotFoundException("El producto no existe");
            }

            Supplier? findSupplier = await this.dbContext.Suppliers!.FindAsync(purchaseDTO.SupplierId);
            if (findSupplier == null)
            {
                throw new KeyNotFoundException("El proveedor no existe");
            }
            DateTime postDatePurchase = DateTime.ParseExact(purchaseDTO.datePurchase!, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            find.purchasePrice = purchaseDTO.purchasePrice;
            find.salePrice = purchaseDTO.salePrice;
            find.Quantity = purchaseDTO.Quantity;
            find.Code = purchaseDTO.Code;
            find.Description = purchaseDTO.Description;
            find.datePurchase = DateOnly.FromDateTime(postDatePurchase);
            find.ProductId = purchaseDTO.ProductId;
            find.SupplierId = purchaseDTO.SupplierId;

            await ModifyProductAsync(find);
            await this.dbContext.SaveChangesAsync();

            return MapPurchase(find);
        }

        async Task<PurchaseDTO?> IPurchaseRepository.DeletePurchase(int id)
        {
            Purchase? find = await dbContext.Purchases!.FindAsync(id);
            if (find != null)
            {
                this.dbContext.Remove(find);
                this.dbContext.SaveChanges();
                return MapPurchase(find);
            }
            return null;
        }

        async Task<List<Purchase>> IPurchaseRepository.GetByPage(int page)
        {
            const int pageSize = 10;
            List<Purchase> purchases = await this.dbContext.Purchases!.ToListAsync();
            int totalPages = (int)Math.Ceiling((double)purchases.Count / pageSize);
            return (page <= totalPages) ? purchases.Skip((page - 1) * pageSize).Take(pageSize).ToList() : new List<Purchase>();
        }

        async Task ModifyProductAsync(Purchase purchase)
        {
            Product? findProduct = await this.dbContext.Products.FindAsync(purchase.ProductId);
            if (findProduct != null)
            {
                findProduct.salePrice = purchase.salePrice;
                findProduct.Quantity += purchase.Quantity;
            }
            await this.dbContext.SaveChangesAsync();
        }
    }
}
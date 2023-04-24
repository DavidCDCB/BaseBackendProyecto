﻿using Domain.Entities;
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

            await this.dbContext.Purchases!.AddAsync(purchase);
            await this.dbContext.SaveChangesAsync();

            return MapPurchase(purchase);
        }

        async Task<PurchaseDTO?> IPurchaseRepository.UpdatePurchase(int id, PurchaseDTO purchaseDTO)
        {
            Purchase? encontrado = await this.dbContext.Purchases!.FindAsync(id);
            if (encontrado == null)
            {
                return null;
            }
            DateTime postDatePurchase = DateTime.ParseExact(purchaseDTO.datePurchase!, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            encontrado.purchasePrice = purchaseDTO.purchasePrice;
            encontrado.salePrice = purchaseDTO.salePrice;
            encontrado.Quantity = purchaseDTO.Quantity;
            encontrado.Code = purchaseDTO.Code;
            encontrado.Description = purchaseDTO.Description;
            encontrado.datePurchase = DateOnly.FromDateTime(postDatePurchase);
            encontrado.ProductId = purchaseDTO.ProductId;
            encontrado.SupplierId = purchaseDTO.SupplierId;

            await this.dbContext.SaveChangesAsync();

            return MapPurchase(encontrado);
        }

        async Task<PurchaseDTO?> IPurchaseRepository.DeletePurchase(int id)
        {
            Purchase? encontrado = await dbContext.Purchases!.FindAsync(id);
            if (encontrado != null)
            {
                this.dbContext.Remove(encontrado);
                this.dbContext.SaveChanges();
                return MapPurchase(encontrado);
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
    }
}

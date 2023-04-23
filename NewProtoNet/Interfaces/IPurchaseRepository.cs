using Domain.Entities;
using RestServer.DTOs;

namespace RestServer.Interfaces
{
    public interface IPurchaseRepository
    {
        Task<List<Purchase>> GetPurchases();
        Task<List<Purchase>> GetByPage(int page);

        Task<Purchase> GetPurchase(int id);
        Task<Purchase> PostPurchase(PurchaseDTO Purchase);
        Task<Purchase> UpdatePurchase(int id, PurchaseDTO Purchase);
        Task<Purchase> DeletePurchase(int id);
    }
}

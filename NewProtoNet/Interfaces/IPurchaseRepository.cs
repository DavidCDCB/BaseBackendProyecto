using Domain.Entities;
using RestServer.DTOs;

namespace RestServer.Interfaces
{
    public interface IPurchaseRepository
    {
        Task<List<PurchaseDTO>> GetPurchases();
        Task<List<Purchase>> GetByPage(int page);

        Task<PurchaseDTO> GetPurchase(int id);
        Task<PurchaseDTO> PostPurchase(PurchaseDTO Purchase);
        Task<PurchaseDTO> UpdatePurchase(int id, PurchaseDTO Purchase);
        Task<PurchaseDTO> DeletePurchase(int id);
    }
}

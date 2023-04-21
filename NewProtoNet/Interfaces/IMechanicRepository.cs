using Domain.Entities;
using RestServer.DTOs;

namespace RestServer.Interfaces
{
    public interface IMechanicRepository
    {
        Task<List<Mechanic>> GetMechanics();
        Task<Mechanic> GetMechanic(int id);
        Task<Mechanic> PostMechanic(MechanicDTO mechanic);
        Task<Mechanic> UpdateMechanic(int id, MechanicDTO mechanic);
        Task<Mechanic> DeleteMechanic(int id);
        List<Mechanic> SeedMechanics(int size);
        Task<List<Mechanic>> GetByPage(int page);
    }
}

using Domain.Entities;
using NewProtoNet.DTOs;

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
    }
}

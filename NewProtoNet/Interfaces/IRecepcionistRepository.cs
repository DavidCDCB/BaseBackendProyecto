using Domain.Entities;
using RestServer.DTOs;

namespace RestServer.Interfaces
{
    public interface IReceptionistRepository
    {
        Task<List<Receptionist>> GetReceptionists();

        Task<List<User>> GetReceptionistsUsers();
        Task<List<Receptionist>> GetByPage(int page);

        Task<Receptionist> GetReceptionist(int id);
        Task<Receptionist> PostReceptionist(ReceptionistDTO Receptionist);
        Task<Receptionist> UpdateReceptionist(int id, ReceptionistDTO Receptionist);
        Task<Receptionist> DeleteReceptionist(int id);
    }
}

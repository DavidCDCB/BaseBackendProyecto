using Domain.Entities;
using RestServer.DTOs;

namespace RestServer.Interfaces
{
    public interface IRecepcionistRepository
    {
        Task<List<Recepcionist>> GetRecepcionists();
        Task<List<Recepcionist>> GetByPage(int page);

        Task<Recepcionist> GetRecepcionist(int id);
        Task<Recepcionist> PostRecepcionist(RecepcionistDTO Recepcionist);
        Task<Recepcionist> UpdateRecepcionist(int id, RecepcionistDTO Recepcionist);
        Task<Recepcionist> DeleteRecepcionist(int id);
    }
}

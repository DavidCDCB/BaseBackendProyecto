using Domain.Entities;
using RestServer.DTOs;

namespace RestServer.Interfaces
{
  public interface IRequestRepository
  {
    Task<List<RequestDTO>> GetRequests();
    Task<RequestDTO?> GetRequest(int id);
    Task<RequestDTO> PostRequest(RequestDTO request);
    Task<RequestDTO?> UpdateRequest(int id, RequestDTO request);
    Task<RequestDTO?> DeleteRequest(int id);
    Task<List<RequestDTO>> GetRequestsByClient(int id);
    Task<List<RequestDTO>> GetRequestsByService(int id);
  }
}

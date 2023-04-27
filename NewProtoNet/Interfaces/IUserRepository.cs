using Domain.Entities;
using RestServer.DTOs;

namespace RestServer.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsers();
        Task<List<User>> GetByPage(int page);
        Task<User> GetUser(int id);
        Task<User> PostUser(UserDTO user);
        Task<User> UpdateUser(int id, UserDTO user);
        Task<User> DeleteUser(int id);
        Task<User> GetUserCredentials(LoginDTO login);
        
    }
}

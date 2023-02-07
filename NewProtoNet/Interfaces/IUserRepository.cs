using Domain.Entities;
using Domain.DTOs;

namespace NewProtoNet.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        Task<User> GetUser(int id);
        Task<User> PostUser(UserDTO user);
        Task<User> UpdateUser(int id, UserDTO user);
        Task<User> DeleteUser(int id);
    }
}

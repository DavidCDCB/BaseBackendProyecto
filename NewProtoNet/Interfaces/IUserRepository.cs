﻿using Domain.Entities.Base;
using NewProtoNet.DTOs;

namespace NewProtoNet.Interfaces
{
    public interface IUserRepository
  {
    Task<List<User>> GetUsers();
    Task<User> GetUser(int id);
    Task<User> PostUser(UserDTO user);
    Task<User> UpdateUser(int id, UserDTO user);
    Task<User> DeleteUser(int id);
    List<User> SeedUsers(int size);
  }
}

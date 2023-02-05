using Microsoft.AspNetCore.Mvc;
using NewProtoNet.Data;
using NewProtoNet.Interfaces;
using NewProtoNet.Models;

namespace NewProtoNet.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext dbContext;

        public UserRepository(UserDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        IEnumerable<User> IUserRepository.GetUsers()
        {
            return this.dbContext.Users;
        }

        async Task<User> IUserRepository.GetUser(int id)
        {
            return await dbContext.Users.FindAsync(id);
        }

        async Task<User> IUserRepository.PostUser(UserDTO user)
        {
            User usuario = new User()
            {
                FullName = user.FullName,
                Email = user.Email,
                Phone = user.Phone
            };

            await this.dbContext.Users.AddAsync(usuario);
            await this.dbContext.SaveChangesAsync();

            return usuario;
        }

        async Task<User> IUserRepository.UpdateUser(int id, UserDTO user)
        {
            var encontrado = await this.dbContext.Users.FindAsync(id);
            if (encontrado == null)
            {
                return encontrado;
            }

            encontrado.FullName = user.FullName;
            encontrado.Email = user.Email;
            encontrado.Phone = user.Phone;
            await this.dbContext.SaveChangesAsync();
            
            return encontrado;
        }

        async Task<User> IUserRepository.DeleteUser(int id)
        {
            var encontrado = await this.dbContext.Users.FindAsync(id);
            if (encontrado == null)
            {
                return encontrado;
            }
            this.dbContext.Remove(encontrado);
            this.dbContext.SaveChanges();
            return encontrado;
        }

    }
}

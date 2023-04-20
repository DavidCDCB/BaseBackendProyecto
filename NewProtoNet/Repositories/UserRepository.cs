using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using RestServer.Data;
using RestServer.DTOs;
using RestServer.Interfaces;
using System.Drawing.Printing;

namespace RestServer.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly BaseDbContext dbContext;

        public UserRepository(BaseDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        async Task<List<User>> IUserRepository.GetUsers()
        {
            return await this.dbContext.Users!.ToListAsync();
        }

        async Task<User?> IUserRepository.GetUser(int id)
        {
            User? User = await dbContext.Users!.FirstOrDefaultAsync(m => m.Id == id);
            return (User != null) ? User : null;
        }

        async Task<User> IUserRepository.PostUser(UserDTO UserDTO)
        {
            User User = new User()
            {
                Id = UserDTO.Id,
                Email = UserDTO.Email,
                Password = UserDTO.Password,
                Role = UserDTO.Role,
            };

            await this.dbContext.Users!.AddAsync(User);
            await this.dbContext.SaveChangesAsync();

            return User;
        }

        async Task<User?> IUserRepository.UpdateUser(int id, UserDTO User)
        {
            User? encontrado = await this.dbContext.Users!.FindAsync(id);
            if (encontrado == null)
            {
                return encontrado;
            }

            encontrado.Id = User.Id;
            encontrado.Email = User.Email;
            encontrado.Password = User.Password;
            encontrado.Role = User.Role;
            await this.dbContext.SaveChangesAsync();

            return encontrado;
        }

        async Task<User?> IUserRepository.DeleteUser(int id)
        {
            User? encontrado = await dbContext.Users!.FindAsync(id);
            if (encontrado != null)
            {
                this.dbContext.Remove(encontrado);
                this.dbContext.SaveChanges();
            }
            return encontrado!;
        }

        async Task<List<User>> IUserRepository.GetByPage(int page)
        {
            const int pageSize = 10;
            List<User> Users = await this.dbContext.Users!.ToListAsync();
            int totalPages = (int)Math.Ceiling((double)Users.Count / pageSize);
            return (page <= totalPages) ? Users.Skip((page - 1) * pageSize).Take(pageSize).ToList() : new List<User>();
        }
    }
}
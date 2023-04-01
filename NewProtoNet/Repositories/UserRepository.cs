using NewProtoNet.Data;
using NewProtoNet.Interfaces;
using Domain.Entities;
using NewProtoNet.DTOs;
using Bogus;
using Microsoft.EntityFrameworkCore;

// La lógica de negocio debe estar en la capa de aplicacion sin usar el context

namespace NewProtoNet.Repositories
{
  public class UserRepository : IUserRepository
  {
    private readonly BaseDbContext dbContext;

    public UserRepository(BaseDbContext dbContext)
    {
      this.dbContext = dbContext;
    }

    List<User> IUserRepository.SeedUsers(int size)
    {
      int ids = 1;
      Faker<User> fakeData = new Faker<User>()
          .RuleFor(m => m.Id, f => ids++)
          .RuleFor(m => m.FullName, f => f.Person.FullName)
          .RuleFor(m => m.Email, f => f.Person.Email)
          .RuleFor(m => m.Phone, f => f.Random.Number(100, 10000));

      this.dbContext.RemoveRange(dbContext.Users);

      List<User> seedData = fakeData.Generate(size);

      this.dbContext.AddRange(seedData);
      this.dbContext.SaveChanges();
      return seedData;
    }

    async Task<List<User>> IUserRepository.GetUsers()
    {
      return await this.dbContext.Users!.ToListAsync();
    }

    async Task<User?> IUserRepository.GetUser(int id)
    {
      Console.WriteLine("OKss");
      User? user = await dbContext.Users!.FirstOrDefaultAsync(m => m.Id == id);
      return (user != null) ? user : null;
    }

    async Task<User> IUserRepository.PostUser(UserDTO user)
    {
      User usuario = new User()
      {
        FullName = user.FullName,
        Email = user.Email,
        Phone = user.Phone,
        Courses = user.Courses
      };

      await this.dbContext.Users!.AddAsync(usuario);
      await this.dbContext.SaveChangesAsync();

      return usuario;
    }

    async Task<User> IUserRepository.UpdateUser(int id, UserDTO user)
    {
      User? encontrado = await this.dbContext.Users!.FindAsync(id);
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
      User? encontrado = await dbContext.Users!.FindAsync(id);
      if (encontrado != null)
      {
        this.dbContext.Remove(encontrado);
        this.dbContext.SaveChanges();
      }
      return encontrado;
    }

  }
}

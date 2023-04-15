using RestServer.Data;
using RestServer.Interfaces;
using Domain.Entities;
using RestServer.DTOs;
using Bogus;
using Microsoft.EntityFrameworkCore;

// La lógica de negocio debe estar en la capa de aplicacion sin usar el context

namespace RestServer.Repositories
{
    //public class UserRepository : IUserRepository
    //{
    //    //private readonly BaseDbContext dbContext;

    //    //public UserRepository(BaseDbContext dbContext)
    //    //{
    //    //    this.dbContext = dbContext;
    //    //}

    //    //List<User> IUserRepository.Seedusers(int size)
    //    //{
    //    //    int ids = 1;
    //    //    Faker<User> fakeData = new Faker<User>()
    //    //        .RuleFor(m => m.Id, f => ids++)
    //    //        .RuleFor(m => m.Email, f => f.Person.Email)
    //    //        .RuleFor(m => m.Password, f => f.Person.Password)              
    //    //        .RuleFor(m => m.Phone, f => f.Random.Number(100, 10000));

    //    //    this.dbContext.RemoveRange(dbContext.users);

    //    //    List<User> seedData = fakeData.Generate(size);

    //    //    this.dbContext.AddRange(seedData);
    //    //    this.dbContext.SaveChanges();
    //    //    return seedData;
    //    //}

    //    //async Task<List<User>> IUserRepository.Getusers()
    //    //{
    //    //    return await this.dbContext.users!.ToListAsync();
    //    //}

    //    //async Task<User?> IUserRepository.GetUser(int id)
    //    //{
    //    //    Console.WriteLine("OKss");
    //    //    User? user = await dbContext.users!.FirstOrDefaultAsync(m => m.Id == id);
    //    //    return (user != null) ? user : null;
    //    //}

    //    //async Task<User> IUserRepository.PostUser(UserDTO user)
    //    //{
    //    //    User usuario = new User()
    //    //    {
    //    //        FullName = user.FullName,
    //    //        Email = user.Email,
    //    //        Phone = user.Phone,
    //    //        Courses = user.Courses
    //    //    };

    //    //    await this.dbContext.users!.AddAsync(usuario);
    //    //    await this.dbContext.SaveChangesAsync();

    //    //    return usuario;
    //    //}

    //    //async Task<User> IUserRepository.UpdateUser(int id, UserDTO user)
    //    //{
    //    //    User? encontrado = await this.dbContext.users!.FindAsync(id);
    //    //    if (encontrado == null)
    //    //    {
    //    //        return encontrado;
    //    //    }

    //    //    encontrado.FullName = user.FullName;
    //    //    encontrado.Email = user.Email;
    //    //    encontrado.Phone = user.Phone;
    //    //    await this.dbContext.SaveChangesAsync();

    //    //    return encontrado;
    //    //}

    //    //async Task<User> IUserRepository.DeleteUser(int id)
    //    //{
    //    //    User? encontrado = await dbContext.users!.FindAsync(id);
    //    //    if (encontrado != null)
    //    //    {
    //    //        this.dbContext.Remove(encontrado);
    //    //        this.dbContext.SaveChanges();
    //    //    }
    //    //    return encontrado;
    //    //}

    //}
}

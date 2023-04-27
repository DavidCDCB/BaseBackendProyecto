using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using RestServer.Data;
using RestServer.DTOs;
using RestServer.Interfaces;

namespace RestServer.Repositories
{
  public class VehicleRepository : IVehicleRepository
  {
    private readonly BaseDbContext dbContext;

    public VehicleRepository(BaseDbContext dbContext)
    {
      this.dbContext = dbContext;
    }

    async Task<List<Vehicle>> IVehicleRepository.GetVehicles()
    {
      return await this.dbContext.Vehicles!.ToListAsync();
    }

    async Task<Vehicle?> IVehicleRepository.GetVehicle(int id)
    {
      Vehicle? Vehicle = await dbContext.Vehicles!.FirstOrDefaultAsync(m => m.Id == id);
      return (Vehicle != null) ? Vehicle : null;
    }

    async Task<Vehicle> IVehicleRepository.PostVehicle(VehicleDTO Vehicle)
    {
      Vehicle vehiculo = new Vehicle()
      {
        Plate = Vehicle.Plate,
        Model = Vehicle.Model,
        Year = Vehicle.Year,
        Description = Vehicle.Description,
        Color = Vehicle.Color,
        ClientId = Vehicle.ClientId,
      };

      await this.dbContext.Vehicles!.AddAsync(vehiculo);
      await this.dbContext.SaveChangesAsync();

      return vehiculo;
    }

    async Task<Vehicle?> IVehicleRepository.UpdateVehicle(int id, VehicleDTO Vehicle)
    {
      Vehicle? find = await this.dbContext.Vehicles!.FindAsync(id);
      if (find == null)
      {
        return find;
      }

      find.Plate = Vehicle.Plate;
      find.Model = Vehicle.Model;
      find.Year = Vehicle.Year;
      find.Description = Vehicle.Description;
      find.Color = Vehicle.Color;

      await this.dbContext.SaveChangesAsync();

      return find;
    }

    async Task<Vehicle?> IVehicleRepository.DeleteVehicle(int id)
    {
      Vehicle? find = await dbContext.Vehicles!.FindAsync(id);
      if (find != null)
      {
        this.dbContext.Remove(find);
        this.dbContext.SaveChanges();
      }
      return find;
    }

    async Task<List<Vehicle>> IVehicleRepository.GetVehiclesByClient(int id)
    {
      List<Vehicle> vehicles = await this.dbContext.Vehicles!.ToListAsync();
      return vehicles.Where(vehicle => vehicle.ClientId == id).ToList();
    }
  }
}

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
      Vehicle? encontrado = await this.dbContext.Vehicles!.FindAsync(id);
      if (encontrado == null)
      {
        return encontrado;
      }

      encontrado.Plate = Vehicle.Plate;
      encontrado.Model = Vehicle.Model;
      encontrado.Year = Vehicle.Year;
      encontrado.Description = Vehicle.Description;
      encontrado.Color = Vehicle.Color;

      await this.dbContext.SaveChangesAsync();

      return encontrado;
    }

    async Task<Vehicle?> IVehicleRepository.DeleteVehicle(int id)
    {
      Vehicle? encontrado = await dbContext.Vehicles!.FindAsync(id);
      if (encontrado != null)
      {
        this.dbContext.Remove(encontrado);
        this.dbContext.SaveChanges();
      }
      return encontrado;
    }

    async Task<List<Vehicle>> IVehicleRepository.GetVehiclesByClient(int id)
    {
      List<Vehicle> vehicles = await this.dbContext.Vehicles!.ToListAsync();
      return vehicles.Where(vehicle => vehicle.ClientId == id).ToList();
    }
  }
}

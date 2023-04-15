using Domain.Entities;
using RestServer.DTOs;

namespace RestServer.Interfaces
{
  public interface IVehicleRepository
  {
    Task<List<Vehicle>> GetVehicles();
    Task<Vehicle?> GetVehicle(int id);
    Task<List<Vehicle>> GetVehiclesByClient(int id);
    Task<Vehicle> PostVehicle(VehicleDTO vehicle);
    Task<Vehicle?> UpdateVehicle(int id, VehicleDTO vehicle);
    Task<Vehicle?> DeleteVehicle(int id);
  }
}

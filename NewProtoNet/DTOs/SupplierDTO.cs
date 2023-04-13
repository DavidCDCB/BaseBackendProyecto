using Domain.Entities;

namespace RestServer.DTOs
{
  public class SupplierDTO
  {
    public int Id { get; set; }
    public string? Nit { get; set; }
    public string? Name { get; set; }
    public string? Company { get; set; }
    public string? SurName { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
  }
}

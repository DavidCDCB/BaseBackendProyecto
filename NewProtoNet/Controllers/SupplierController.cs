using RestServer.DTOs;
using Microsoft.AspNetCore.Mvc;
using RestServer.Interfaces;
using Domain.Entities.Base;

namespace RestServer.Controllers
{
  public class SupplierController
  {
    private readonly ISupplierRepository supplierRepository;

    public SupplierController(ISupplierRepository supplierRepository)
    {
      this.supplierRepository = supplierRepository;
    }
  }
}

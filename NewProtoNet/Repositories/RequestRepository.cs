using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using RestServer.Data;
using RestServer.DTOs;
using RestServer.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestServer.Repositories
{
    public class RequestRepository : IRequestRepository
  {
    private readonly BaseDbContext dbContext;

    private RequestDTO MapRequest(Request r)
    {
      return new RequestDTO
      {
        Id = r.Id,
        StarDate = r.StarDate.ToString(),
        EndDate = r.EndDate.ToString(),
        State = r.State,
        ClientId = r.ClientId,
        ServiceId = r.ServiceId
      };
    }

    private List<RequestDTO> ChangeDates(List<Request> requests)
    {
      List<RequestDTO> requestsDto = new List<RequestDTO>();
      requests.ForEach(r =>
      {
        requestsDto.Add(MapRequest(r));
      });

      return requestsDto;
    }
    public RequestRepository(BaseDbContext dbContext)
    {
      this.dbContext = dbContext;
    }

    async Task<List<RequestDTO>> IRequestRepository.GetRequests()
    {
      List<Request> requests = await this.dbContext.Requests!.ToListAsync();
      return await Task.FromResult(ChangeDates(requests));
    }
        async Task<Request>  getRequestClass(int id)
        {
            Request? request = await this.dbContext.Requests!.FindAsync(id);
            if (request == null)
            {
                throw new KeyNotFoundException("La request no existe");
            }
            return request;
        }

        async Task<List<Mechanic> > getMechanicsClass(List<Mechanic> mechanics)
        {
            if (mechanics == null || !mechanics.Any())
            {
                throw new KeyNotFoundException("lista de mecanicos vacios");
            }
            List<Mechanic> mechanicsList = new List<Mechanic>();
            foreach (Mechanic tempMechanic in mechanics)
            {
                Mechanic? mechanic = await this.dbContext.Mechanics!.FindAsync(tempMechanic.Id);
                if (mechanic != null)
                {
                    mechanicsList.Add(mechanic);
                }
                else throw new KeyNotFoundException("No se encontraron los mecanicos");
            }
            return mechanicsList;
        }

        async Task<List<Product>> getProductsClass(List<Product> products)
        {
            if (products == null || !products.Any())
            {
                throw new KeyNotFoundException("lista de productos vacios");
            }
            List<Product> productsList = new List<Product>();
            foreach (Product tempProduct in products)
            {
                Product? product = await this.dbContext.Products!.FindAsync(tempProduct.Id);
                if (product != null)
                {
                    if (product.Quantity >= tempProduct.Quantity)
                    {
                        product.Quantity -= tempProduct.Quantity;
                        productsList.Add(product);
                    }
                    else throw new KeyNotFoundException("No hay suficientes productos");
                    
                }
                else throw new KeyNotFoundException("No se encontraron los productos");
            }
            return productsList;
        }

        async Task<List<Product>> IRequestRepository.UpdateRequestProducts(ProductRequestDTO requestProducts)
        {
            //buscar la request 
            Request? request = await this.getRequestClass(requestProducts.RequestsId);            

            //validar que los mecanicos existan
            List<Mechanic> mechanics = await this.getMechanicsClass(requestProducts.Mechanics);
            //validar que si la request tiene mecanicos asignados
            List<Mechanic> mechanicRequest = await this.dbContext.Requests!.Where(r => r.Id == requestProducts.RequestsId).SelectMany(r => r.Mechanics).ToListAsync();
            if (mechanicRequest == null || !mechanicRequest.Any())
            {
                request.Mechanics = mechanics;                
            }
            else throw new KeyNotFoundException("La request ya tiene mecanicos asignados");

            //adicionar productos a la request
            List<Product> products = await this.getProductsClass(requestProducts.Products);
            //validar que si la request tiene productos asignados
            List<Product> productRequest = await this.dbContext.Requests!.Where(r => r.Id == requestProducts.RequestsId).SelectMany(r => r.Products).ToListAsync();
            if (productRequest == null || !productRequest.Any())
            {
                request.Products = products;
            }
            else throw new KeyNotFoundException("La request ya tiene productos asignados");
            await this.dbContext.SaveChangesAsync();

            return products;
        }


        async Task<RequestDTO?> IRequestRepository.GetRequest(int id)
    {
      Request? request = await dbContext.Requests!.FirstOrDefaultAsync(m => m.Id == id);
      return (request != null) ? MapRequest(request) : null;
    }

    async Task<RequestDTO> IRequestRepository.PostRequest(RequestDTO requestDTO)
    {
      DateTime fechaInicio = DateTime.ParseExact(requestDTO.StarDate!, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
      DateTime fechaFin = DateTime.ParseExact(requestDTO.StarDate!, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
      Request request = new Request()
      {
        StarDate = DateOnly.FromDateTime(fechaInicio),
        EndDate = DateOnly.FromDateTime(fechaFin),
        State = requestDTO.State,
        ClientId = requestDTO.ClientId,
        ServiceId = requestDTO.ServiceId
      };

      await this.dbContext.Requests!.AddAsync(request);
      await this.dbContext.SaveChangesAsync();

      return MapRequest(request);
    }

    async Task<RequestDTO?> IRequestRepository.UpdateRequest(int id, RequestDTO requestDTO)
    {
      Request? find = await this.dbContext.Requests!.FindAsync(id);
      if (find == null)
      {
        return null;
      }
      DateTime fechaInicio = DateTime.ParseExact(requestDTO.StarDate!, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
      DateTime fechaFin = DateTime.ParseExact(requestDTO.EndDate!, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
      
      find.StarDate = DateOnly.FromDateTime(fechaInicio);
      find.EndDate = DateOnly.FromDateTime(fechaFin);
      find.State = requestDTO.State;
      find.ClientId = requestDTO.ClientId;
      find.ServiceId = requestDTO.ServiceId;

      await this.dbContext.SaveChangesAsync();

      return MapRequest(find);
    }

    async Task<RequestDTO?> IRequestRepository.DeleteRequest(int id)
    {
      Request? find = await dbContext.Requests!.FindAsync(id);
      if (find != null)
      {
        this.dbContext.Remove(find);
        this.dbContext.SaveChanges();
        return MapRequest(find);
      }
      return null;
    }

    async Task<List<RequestDTO>> IRequestRepository.GetRequestsByClient(int id)
    {
      List<Request> requests = await this.dbContext.Requests!.ToListAsync();
      List<Request> requestsByClient = requests.Where(requests => requests.ClientId == id).ToList();
      return await Task.FromResult(ChangeDates(requestsByClient));
    }

    async Task<List<RequestDTO>> IRequestRepository.GetRequestsByService(int id)
    {
      List<Request> requests = await this.dbContext.Requests!.ToListAsync();
      List<Request> requestsByService = requests.Where(requests => requests.ServiceId == id).ToList();
      return await Task.FromResult(ChangeDates(requestsByService));
    }

  }
}

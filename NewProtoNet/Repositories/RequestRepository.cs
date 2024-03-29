﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using RestServer.Data;
using RestServer.DTOs;
using RestServer.Interfaces;

namespace RestServer.Repositories
{
  public class RequestRepository : IRequestRepository
  {
    private readonly BaseDbContext dbContext;

    private RequestDTO MapRequest(Request r)
    {
      return new RequestDTO
      {
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

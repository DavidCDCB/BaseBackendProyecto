﻿
namespace RestServer.DTOs
{
  public class RequestDTO
  {
    public string? StarDate { get; set; }
    public string? EndDate { get; set; }
    public string? State { get; set; }
    public int? ClientId { get; set; }
    public int? ServiceId { get; set; }
  }
}

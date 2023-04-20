﻿using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServer.DTOs
{
    public class ReportDTO
    {
        public int Id { get; set; }
        public string? Type { get; set; }
    }
}

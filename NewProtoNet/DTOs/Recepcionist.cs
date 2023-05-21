﻿using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServer.DTOs
{
    public class RecepcionistDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public float? Salary { get; set; }
        public string? Email { get; set; }
    }
}


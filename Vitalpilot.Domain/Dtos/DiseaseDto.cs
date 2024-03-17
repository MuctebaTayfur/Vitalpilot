﻿using System.ComponentModel.DataAnnotations;
using Vitalpilot.Domain.Dtos.Interfaces;

namespace Vitalpilot.Domain.Dtos
{
    public class DiseaseDto : IDto
    {
        [Required]
        public string Name { get; set; } = null!;

        public string? Description { get; set; }
    }
}
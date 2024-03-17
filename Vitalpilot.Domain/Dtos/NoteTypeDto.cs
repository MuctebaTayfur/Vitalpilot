using System.ComponentModel.DataAnnotations;
using Vitalpilot.Domain.Dtos.Interfaces;

namespace Vitalpilot.Domain.Dtos
{
    public class NoteTypeDto : IDto
    {
        [Required]
        public string Name { get; set; } = null!;

        public string? Description { get; set; }
    }
}
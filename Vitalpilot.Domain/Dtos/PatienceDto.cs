using System.ComponentModel.DataAnnotations;
using Vitalpilot.Domain.Dtos.Interfaces;

namespace Vitalpilot.Domain.Dtos
{
    public class PatienceDto : IDto
    {
        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public int Status { get; set; }

        public string? MiddleName { get; set; }
    }
}
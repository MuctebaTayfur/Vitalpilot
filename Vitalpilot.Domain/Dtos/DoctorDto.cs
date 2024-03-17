using System.ComponentModel.DataAnnotations;
using Vitalpilot.Domain.Dtos.Interfaces;

namespace Vitalpilot.Domain.Dtos
{
    public class DoctorDto : IDto
    {
        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public Guid ClinicId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        public string? MiddleName { get; set; }
    }
}
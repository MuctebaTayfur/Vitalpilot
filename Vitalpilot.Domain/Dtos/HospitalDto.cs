using System.ComponentModel.DataAnnotations;
using Vitalpilot.Domain.Dtos.Interfaces;

namespace Vitalpilot.Domain.Dtos
{
    public class HospitalDto : IDto
    {
        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string City { get; set; } = null!;

        [Required]
        public string Address { get; set; } = null!;

        [Required]
        public string PhoneNumber { get; set; } = null!;

        public string? Website { get; set; }
    }
}
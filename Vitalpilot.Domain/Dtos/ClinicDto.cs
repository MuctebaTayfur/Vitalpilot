using System.ComponentModel.DataAnnotations;
using Vitalpilot.Domain.Dtos.Interfaces;

namespace Vitalpilot.Domain.Dtos
{
    public class ClinicDto : IDto
    {
        [Required]
        public Guid HospitalId { get; set; }

        [Required]
        public Guid Name { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public string? Description { get; set; }

        public string? HostpitalSection { get; set; }
    }
}
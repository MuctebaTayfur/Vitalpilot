using System.ComponentModel.DataAnnotations;
using Vitalpilot.Domain.Dtos.Interfaces;

namespace Vitalpilot.Domain.Dtos
{
    public class ClinicDto : BaseEntityDto
    {
        [Required]
        public Guid HospitalId { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public bool IsActive { get; set; }

        public string? Description { get; set; }
    }
}
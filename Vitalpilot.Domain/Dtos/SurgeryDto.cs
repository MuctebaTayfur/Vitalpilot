using System.ComponentModel.DataAnnotations;
using Vitalpilot.Domain.Dtos.Interfaces;

namespace Vitalpilot.Domain.Dtos
{
    public class SurgeryDto : IDto
    {
        [Required]
        public Guid DoctorId { get; set; }

        [Required]
        public Guid PatienceId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public string? Description { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Status { get; set; }
    }
}
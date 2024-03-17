using System.ComponentModel.DataAnnotations;
using Vitalpilot.Domain.Dtos.Interfaces;

namespace Vitalpilot.Domain.Dtos
{
    public class AppointmentDto : IDto
    {
        [Required]
        public DateTime AppointmentDate { get; set; }

        [Required]
        public Guid PatienceId { get; set; }

        [Required]
        public Guid DoctorId { get; set; }

        [Required]
        public Guid ClinicId { get; set; }

        [Required]
        public int Status { get; set; }

        public string? PatienceHistory { get; set; }
    }
}
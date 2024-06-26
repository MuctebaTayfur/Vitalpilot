using Vitalpilot.Domain.Dtos.Interfaces;

namespace Vitalpilot.Domain.Dtos
{
    public class PrescriptionDto : BaseEntityDto
    {
        public Guid PatienceId { get; set; }
        public Guid AppointmentId { get; set; }
        public string? Description { get; set; }
    }
}
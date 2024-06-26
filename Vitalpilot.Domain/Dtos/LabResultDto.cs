using System.ComponentModel.DataAnnotations;
using Vitalpilot.Domain.Dtos.Interfaces;

namespace Vitalpilot.Domain.Dtos
{
    public class LabResultDto : BaseEntityDto
    {
        [Required]
        public Guid PatienceId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public Guid? FileId { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
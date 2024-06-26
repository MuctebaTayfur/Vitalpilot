using System.ComponentModel.DataAnnotations;
using Vitalpilot.Domain.Dtos.Interfaces;

namespace Vitalpilot.Domain.Dtos
{
    public class PatienceNoteDto : BaseEntityDto
    {
        [Required]
        public Guid PatiencId { get; set; }

        [Required]
        public Guid NoteTypeId { get; set; }

        [Required]
        public string NoteText { get; set; } = null!;
    }
}
using System.ComponentModel.DataAnnotations;
using Vitalpilot.Domain.Dtos.Interfaces;

namespace Vitalpilot.Domain.Dtos
{
    public class FileDto : BaseEntityDto
    {
        [Required]
        public Guid FileTypeId { get; set; }

        public string? FileUrl { get; set; } = null!;
        public string? FileExtension { get; set; } = null!;
    }
}
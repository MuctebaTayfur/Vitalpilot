using System.ComponentModel.DataAnnotations;
using Vitalpilot.Domain.Dtos.Interfaces;

namespace Vitalpilot.Domain.Dtos
{
    public class UserDto : IDto
    {
        [Required]
        public string UserName { get; set; } = null!;

        [Required]
        public string EmailAddress { get; set; } = null!;

        [Required]
        public Guid HospitalId { get; set; }

        public string Password { get; set; } = null!;
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
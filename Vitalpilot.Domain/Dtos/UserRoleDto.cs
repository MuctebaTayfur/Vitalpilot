using System.ComponentModel.DataAnnotations;
using Vitalpilot.Domain.Dtos.Interfaces;

namespace Vitalpilot.Domain.Dtos
{
    public class UserRoleDto : BaseEntityDto
    {
        [Required]
        public Guid RoleId { get; set; }

        [Required]
        public Guid UserId { get; set; }
    }
}
using Vitalpilot.Domain.Dtos.Interfaces;

namespace Vitalpilot.Domain.Dtos
{
    public class BaseEntityDto : IDto
    {
        public Guid UniqueId { get; internal set; }

        public Guid FriendlyId { get; internal set; }
    }
}
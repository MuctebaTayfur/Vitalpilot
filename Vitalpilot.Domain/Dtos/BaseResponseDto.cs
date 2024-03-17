using Vitalpilot.Domain.Dtos.Interfaces;

namespace Vitalpilot.Domain.Dtos
{
    public class BaseResponseDto<TEntityDto> where TEntityDto : IDto
    {
        public TEntityDto? Entity { get; private set; }
        public string? Message { get; private set; }
        public bool Success { get; private set; }
    }
}
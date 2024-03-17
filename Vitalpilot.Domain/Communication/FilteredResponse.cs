using Vitalpilot.Domain.Dtos.Interfaces;
using Vitalpilot.Domain.Filters;

namespace Vitalpilot.Domain.Communication
{
    public class FilteredResponse<TResource, TFilter>
        where TResource : IDto
        where TFilter : BaseFilter
    {
        public IEnumerable<TResource> Data { get; set; }
        public TFilter Filter { get; set; }
        public int DataCount { get; set; }
        public int TotalCount { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitalpilot.Domain.Filters.Interfaces
{
    public interface IFilter
    {
        int Skip { get; set; }
        int Take { get; set; }
        string? Predicate { get; set; }
        string? OrderBy { get; set; }
    }
}
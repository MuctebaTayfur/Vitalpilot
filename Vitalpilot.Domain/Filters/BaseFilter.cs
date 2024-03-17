using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vitalpilot.Domain.Filters.Interfaces;

namespace Vitalpilot.Domain.Filters
{
    public abstract class BaseFilter : IFilter
    {
        [Range(0, int.MaxValue, ErrorMessage = "Skip cannot be negative.")]
        public int Skip { get; set; } = 0;

        [Range(1, int.MaxValue, ErrorMessage = "Take must be positive.")]
        public int Take { get; set; } = 1;

        public string? Predicate { get; set; }

        public string? OrderBy { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vitalpilot.Domain.Dtos.Interfaces;

namespace Vitalpilot.Domain.Dtos
{
    public class FileTypeDto : BaseEntityDto
    {
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vitalpilot.Domain.Helper.Templates;

namespace Vitalpilot.Domain.Helper
{
    public class ApplicationSettings
    {
        public static ConnectionStrings ConnectionStrings { get; set; } = new ConnectionStrings();
    }
}
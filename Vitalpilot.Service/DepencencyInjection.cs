using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vitalpilot.Domain.Services;

namespace Vitalpilot.Services
{
    public static class DepencencyInjection
    {
        public static IServiceCollection AddVitalpilotServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IService<,,>), typeof(Service<,,>));

            return services;
        }
    }
}
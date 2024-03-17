using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Vitalpilot.Domain.Repositories;
using Vitalpilot.EntityFramework.Context;
using Vitalpilot.EntityFramework.Repositories;

namespace Vitalpilot.EntityFramework
{
    public static class DepencencyInjection
    {
        public static IServiceCollection AddVitalpilotEntityFramework(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<VitalpilotDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Vitalpilot")));

            services.AddScoped<VitalpilotDbContext>();

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped<IUnitOfWork, UnitOFWork>();

            return services;
        }
    }
}
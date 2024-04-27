using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tenakth.D6.EntityFramework.Context.Configurations;
using Vitalpilot.Domain.Models;

namespace Vitalpilot.EntityFramework.Context.Configuration.VitalPilot;

public class PatienceConfiguration : BaseModelConfiguration<Patience>
{
    public override void Configure(EntityTypeBuilder<Patience> builder)
    {
        base.Configure(builder);
    }
}
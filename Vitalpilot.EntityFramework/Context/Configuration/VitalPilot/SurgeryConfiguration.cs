using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tenakth.D6.EntityFramework.Context.Configurations;
using Vitalpilot.Domain.Models;

namespace Vitalpilot.EntityFramework.Context.Configuration.VitalPilot;

public class SurgeryConfiguration : BaseModelConfiguration<Surgery>
{
    public override void Configure(EntityTypeBuilder<Surgery> builder)
    {
        base.Configure(builder);
    }
}
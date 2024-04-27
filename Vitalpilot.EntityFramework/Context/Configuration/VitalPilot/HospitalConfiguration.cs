using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tenakth.D6.EntityFramework.Context.Configurations;
using Vitalpilot.Domain.Models;

namespace Vitalpilot.EntityFramework.Context.Configuration.VitalPilot;

public class HospitalConfiguration : BaseModelConfiguration<Hospital>
{
    public override void Configure(EntityTypeBuilder<Hospital> builder)
    {
        base.Configure(builder);
    }
}
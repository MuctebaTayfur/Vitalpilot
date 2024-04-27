using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tenakth.D6.EntityFramework.Context.Configurations;
using Vitalpilot.Domain.Models;

namespace Vitalpilot.EntityFramework.Context.Configuration.VitalPilot;

public class ClinicConfiguration : BaseModelConfiguration<Clinic>
{
    public override void Configure(EntityTypeBuilder<Clinic> builder)
    {
        base.Configure(builder);
    }
}
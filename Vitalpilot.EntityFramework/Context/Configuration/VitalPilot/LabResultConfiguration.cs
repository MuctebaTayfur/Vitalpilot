using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tenakth.D6.EntityFramework.Context.Configurations;
using Vitalpilot.Domain.Models;

namespace Vitalpilot.EntityFramework.Context.Configuration.VitalPilot;

public class LabResultConfiguration : BaseModelConfiguration<LabResult>
{
    public override void Configure(EntityTypeBuilder<LabResult> builder)
    {
        base.Configure(builder);
    }
}
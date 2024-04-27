using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tenakth.D6.EntityFramework.Context.Configurations;
using Vitalpilot.Domain.Models;

namespace Vitalpilot.EntityFramework.Context.Configuration.VitalPilot;

public class DiseaseConfiguration : BaseModelConfiguration<Disease>
{
    public override void Configure(EntityTypeBuilder<Disease> builder)
    {
        base.Configure(builder);
    }
}
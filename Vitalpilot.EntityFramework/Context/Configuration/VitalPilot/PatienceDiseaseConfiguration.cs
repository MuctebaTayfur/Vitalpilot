using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tenakth.D6.EntityFramework.Context.Configurations;
using Vitalpilot.Domain.Models;

namespace Vitalpilot.EntityFramework.Context.Configuration.VitalPilot;

public class PatienceDiseaseConfiguration : BaseModelConfiguration<PatienceDisease>
{
    public override void Configure(EntityTypeBuilder<PatienceDisease> builder)
    {
        base.Configure(builder);
    }
}
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vitalpilot.Domain.Models;

namespace Tenakth.D6.EntityFramework.Context.Configurations;

public class PatienceDiseaseConfiguration : BaseModelConfiguration<PatienceDisease>
{
    public override void Configure(EntityTypeBuilder<PatienceDisease> builder)
    {
        base.Configure(builder);
    }
}
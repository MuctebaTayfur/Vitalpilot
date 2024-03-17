using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vitalpilot.Domain.Models;

namespace Tenakth.D6.EntityFramework.Context.Configurations;

public class DiseaseConfiguration : BaseModelConfiguration<Disease>
{
    public override void Configure(EntityTypeBuilder<Disease> builder)
    {
        base.Configure(builder);
    }
}
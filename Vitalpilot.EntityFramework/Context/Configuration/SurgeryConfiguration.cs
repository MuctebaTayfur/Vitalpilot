using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vitalpilot.Domain.Models;

namespace Tenakth.D6.EntityFramework.Context.Configurations;

public class SurgeryConfiguration : BaseModelConfiguration<Surgery>
{
    public override void Configure(EntityTypeBuilder<Surgery> builder)
    {
        base.Configure(builder);
    }
}
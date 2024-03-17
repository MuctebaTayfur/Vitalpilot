using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vitalpilot.Domain.Models;

namespace Tenakth.D6.EntityFramework.Context.Configurations;

public class PatienceConfiguration : BaseModelConfiguration<Patience>
{
    public override void Configure(EntityTypeBuilder<Patience> builder)
    {
        base.Configure(builder);
    }
}
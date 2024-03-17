using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vitalpilot.Domain.Models;

namespace Tenakth.D6.EntityFramework.Context.Configurations;

public class ClinicConfiguration : BaseModelConfiguration<Clinic>
{
    public override void Configure(EntityTypeBuilder<Clinic> builder)
    {
        base.Configure(builder);
    }
}
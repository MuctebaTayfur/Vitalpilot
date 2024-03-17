using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vitalpilot.Domain.Models;

namespace Tenakth.D6.EntityFramework.Context.Configurations;

public class PrescriptionConfiguration : BaseModelConfiguration<Prescription>
{
    public override void Configure(EntityTypeBuilder<Prescription> builder)
    {
        base.Configure(builder);
    }
}
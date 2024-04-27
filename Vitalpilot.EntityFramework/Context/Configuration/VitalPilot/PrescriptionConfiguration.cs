using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tenakth.D6.EntityFramework.Context.Configurations;
using Vitalpilot.Domain.Models;

namespace Vitalpilot.EntityFramework.Context.Configuration.VitalPilot;

public class PrescriptionConfiguration : BaseModelConfiguration<Prescription>
{
    public override void Configure(EntityTypeBuilder<Prescription> builder)
    {
        base.Configure(builder);
    }
}
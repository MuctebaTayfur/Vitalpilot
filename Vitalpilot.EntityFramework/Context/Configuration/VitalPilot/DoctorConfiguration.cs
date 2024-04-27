using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tenakth.D6.EntityFramework.Context.Configurations;
using Vitalpilot.Domain.Models;

namespace Vitalpilot.EntityFramework.Context.Configuration.VitalPilot;

public class DoctorConfiguration : BaseModelConfiguration<Doctor>
{
    public override void Configure(EntityTypeBuilder<Doctor> builder)
    {
        base.Configure(builder);
    }
}
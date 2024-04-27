using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tenakth.D6.EntityFramework.Context.Configurations;
using Vitalpilot.Domain.Models;

namespace Vitalpilot.EntityFramework.Context.Configuration.VitalPilot;

public class AppointmentConfiguration : BaseModelConfiguration<Appointment>
{
    public override void Configure(EntityTypeBuilder<Appointment> builder)
    {
        base.Configure(builder);
    }
}
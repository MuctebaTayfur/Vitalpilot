using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vitalpilot.Domain.Models;

namespace Tenakth.D6.EntityFramework.Context.Configurations;

public class DoctorConfiguration : BaseModelConfiguration<Doctor>
{
    public override void Configure(EntityTypeBuilder<Doctor> builder)
    {
        base.Configure(builder);
    }
}
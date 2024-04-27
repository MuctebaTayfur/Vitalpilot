using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tenakth.D6.EntityFramework.Context.Configurations;
using Vitalpilot.Domain.Models;

namespace Vitalpilot.EntityFramework.Context.Configuration.VitalPilot;

public class UserRoleConfiguration : BaseModelConfiguration<UserRole>
{
    public override void Configure(EntityTypeBuilder<UserRole> builder)
    {
        base.Configure(builder);
    }
}
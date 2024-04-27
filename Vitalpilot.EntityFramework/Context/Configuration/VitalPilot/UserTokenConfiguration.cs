using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tenakth.D6.EntityFramework.Context.Configurations;
using Vitalpilot.Domain.Models;

namespace Vitalpilot.EntityFramework.Context.Configuration.VitalPilot;

public class UserTokenConfiguration : BaseModelConfiguration<UserToken>
{
    public override void Configure(EntityTypeBuilder<UserToken> builder)
    {
        base.Configure(builder);
    }
}
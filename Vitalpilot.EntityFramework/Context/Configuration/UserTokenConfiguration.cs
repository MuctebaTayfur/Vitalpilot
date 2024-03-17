using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vitalpilot.Domain.Models;

namespace Tenakth.D6.EntityFramework.Context.Configurations;

public class UserTokenConfiguration : BaseModelConfiguration<UserToken>
{
    public override void Configure(EntityTypeBuilder<UserToken> builder)
    {
        base.Configure(builder);
    }
}
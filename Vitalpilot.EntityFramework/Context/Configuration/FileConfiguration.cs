using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vitalpilot.Domain.Models;
using File = Vitalpilot.Domain.Models.File;

namespace Tenakth.D6.EntityFramework.Context.Configurations;

public class FileConfiguration : BaseModelConfiguration<File>
{
    public override void Configure(EntityTypeBuilder<File> builder)
    {
        base.Configure(builder);
    }
}
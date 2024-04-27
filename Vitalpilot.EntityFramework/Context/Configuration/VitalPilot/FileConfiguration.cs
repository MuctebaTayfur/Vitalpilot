using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tenakth.D6.EntityFramework.Context.Configurations;
using Vitalpilot.Domain.Models;
using File = Vitalpilot.Domain.Models.File;

namespace Vitalpilot.EntityFramework.Context.Configuration.VitalPilot;

public class FileConfiguration : BaseModelConfiguration<File>
{
    public override void Configure(EntityTypeBuilder<File> builder)
    {
        base.Configure(builder);
    }
}
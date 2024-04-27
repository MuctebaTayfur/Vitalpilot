using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tenakth.D6.EntityFramework.Context.Configurations;
using Vitalpilot.Domain.Models;

namespace Vitalpilot.EntityFramework.Context.Configuration.VitalPilot;

public class FileTypeConfiguration : BaseModelConfiguration<FileType>
{
    public override void Configure(EntityTypeBuilder<FileType> builder)
    {
        base.Configure(builder);
    }
}
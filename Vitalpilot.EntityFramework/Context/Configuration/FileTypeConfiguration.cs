using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vitalpilot.Domain.Models;

namespace Tenakth.D6.EntityFramework.Context.Configurations;

public class FileTypeConfiguration : BaseModelConfiguration<FileType>
{
    public override void Configure(EntityTypeBuilder<FileType> builder)
    {
        base.Configure(builder);
    }
}
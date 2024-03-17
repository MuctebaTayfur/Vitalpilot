using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vitalpilot.Domain.Models;

namespace Tenakth.D6.EntityFramework.Context.Configurations;

public class NoteTypeConfiguration : BaseModelConfiguration<NoteType>
{
    public override void Configure(EntityTypeBuilder<NoteType> builder)
    {
        base.Configure(builder);
    }
}
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tenakth.D6.EntityFramework.Context.Configurations;
using Vitalpilot.Domain.Models;

namespace Vitalpilot.EntityFramework.Context.Configuration.VitalPilot;

public class NoteTypeConfiguration : BaseModelConfiguration<NoteType>
{
    public override void Configure(EntityTypeBuilder<NoteType> builder)
    {
        base.Configure(builder);
    }
}
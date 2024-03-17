using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vitalpilot.Domain.Models;

namespace Tenakth.D6.EntityFramework.Context.Configurations;

public class PatienceNoteConfiguration : BaseModelConfiguration<PatienceNote>
{
    public override void Configure(EntityTypeBuilder<PatienceNote> builder)
    {
        base.Configure(builder);
    }
}
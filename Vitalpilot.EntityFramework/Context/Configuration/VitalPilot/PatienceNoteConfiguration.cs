using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tenakth.D6.EntityFramework.Context.Configurations;
using Vitalpilot.Domain.Models;

namespace Vitalpilot.EntityFramework.Context.Configuration.VitalPilot;

public class PatienceNoteConfiguration : BaseModelConfiguration<PatienceNote>
{
    public override void Configure(EntityTypeBuilder<PatienceNote> builder)
    {
        base.Configure(builder);
    }
}
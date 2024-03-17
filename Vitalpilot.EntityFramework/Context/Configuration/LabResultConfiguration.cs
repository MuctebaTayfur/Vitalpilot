using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vitalpilot.Domain.Models;

namespace Tenakth.D6.EntityFramework.Context.Configurations;

public class LabResultConfiguration : BaseModelConfiguration<LabResult>
{
    public override void Configure(EntityTypeBuilder<LabResult> builder)
    {
        base.Configure(builder);
    }
}
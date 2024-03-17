using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vitalpilot.Domain;

namespace Tenakth.D6.EntityFramework.Context.Configurations;

public abstract class BaseModelConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
    where TEntity : class, IBase
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.HasKey(a => a.UniqueId);

        builder.Property(b => b.FriendlyId).IsRequired().ValueGeneratedOnAdd().Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

        builder.Property(b => b.UniqueId).IsRequired();
        // CreatedDate
        builder.Property(b => b.CreatedDate).IsRequired().HasDefaultValueSql("GetDate()").ValueGeneratedOnAdd();
        // CreatedById
        builder.Property(b => b.CreatedById).IsRequired();
        // CreatedBy
        builder.Property(b => b.CreatedBy).IsRequired().HasMaxLength(100);
        // LastModifiedDate
        builder.Property(b => b.LastModifiedDate).IsRequired().HasDefaultValueSql("GetDate()");
        // LastModifiedById
        builder.Property(b => b.LastModifiedById).IsRequired();
        // LastModifiedBy
        builder.Property(b => b.LastModifiedBy).IsRequired().HasMaxLength(100);
        // Deleted
        builder.Property(b => b.Deleted).IsRequired().HasDefaultValueSql("0");
        // RowVersion
        builder.Property(b => b.RowVersion).IsRequired().IsConcurrencyToken().ValueGeneratedOnAddOrUpdate().IsRowVersion();
    }
}
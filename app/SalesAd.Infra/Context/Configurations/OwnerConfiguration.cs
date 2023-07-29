using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesAd.Domain.Entities;

namespace SalesAd.Infra.Context.Configurations
{
    public class OwnerConfiguration : IEntityTypeConfiguration<OwnerEntity>
    {
        public void Configure(EntityTypeBuilder<OwnerEntity> builder)
        {
            builder
                .ToTable("TB_OWNER")
                .HasKey(k => new { k.Id });

            builder
                .Property(p => p.Name)
                .HasMaxLength(150)
                .IsRequired();

            builder
                .Property(p => p.Phone)
                .HasMaxLength(11)
                .IsRequired()
                .HasConversion<string>(
                    coreValue => coreValue.ToString(),
                    efValue => efValue
                );

            builder
                .Property(p => p.Email)
                .HasMaxLength(100)
                .IsRequired()
                .HasConversion<string>(
                    coreValue => coreValue.ToString(),
                    efValue => efValue
                );

            builder
                .HasMany(k => k.Announcements)
                .WithOne(k => k.Owner);
        }
    }
}
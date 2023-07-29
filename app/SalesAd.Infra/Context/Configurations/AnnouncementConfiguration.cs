using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesAd.Domain.Entities;

namespace SalesAd.Infra.Context.Configurations
{
    public class AnnouncementConfiguration : IEntityTypeConfiguration<AnnouncementEntity>
    {
        public void Configure(EntityTypeBuilder<AnnouncementEntity> builder)
        {
            builder
                .ToTable("TB_ANNOUNCEMENT")
                .HasKey(k => new { k.Id });

            builder
                .Property(p => p.Size)
                .IsRequired();

            builder
                .Property(p => p.Value)
                .HasColumnType("DECIMAL(15,2)")
                .IsRequired();

            builder
                .Property(p => p.Description)
                .HasMaxLength(500);

            builder
                .HasOne(k => k.Owner)
                .WithMany(k => k.Announcements);

            builder
                .OwnsOne(
                    a => a.Address,
                    addressNavigationBuilder =>
                    {
                        addressNavigationBuilder
                            .ToTable("TB_ANNOUNCEMENT_ADDRESS");

                        addressNavigationBuilder
                            .WithOwner()
                            .HasForeignKey("AnnouncementId");

                        addressNavigationBuilder
                            .Property<Guid>("Id");

                        addressNavigationBuilder
                            .HasKey("Id");
                    }
                );
        }
    }
}
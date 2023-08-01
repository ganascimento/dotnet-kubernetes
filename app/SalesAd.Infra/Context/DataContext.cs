using Microsoft.EntityFrameworkCore;
using SalesAd.Domain.Entities;
using SalesAd.Infra.Context.Configurations;
using SalesAd.Infra.Seeds;

namespace SalesAd.Infra.Context
{
    public class DataContext : DbContext
    {
        public DbSet<OwnerEntity>? Owner { get; set; }
        public DbSet<AnnouncementEntity>? Announcement { get; set; }

        public DataContext() : base() { }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new OwnerConfiguration());
            modelBuilder.ApplyConfiguration(new AnnouncementConfiguration());

            OwnerSeed.Seed(modelBuilder);
            AnnouncementSeed.Seed(modelBuilder);
        }
    }
}
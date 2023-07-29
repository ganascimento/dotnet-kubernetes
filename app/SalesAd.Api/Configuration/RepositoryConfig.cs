using SalesAd.Domain.Interfaces.Repository;
using SalesAd.Domain.Interfaces.Repository.Base;
using SalesAd.Infra.Repository;
using SalesAd.Infra.Repository.Base;

namespace SalesAd.Api.Configuration
{
    public static class RepositoryConfig
    {
        public static IServiceCollection ConfigRepository(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IOwnerRepository, OwnerRepository>();
            services.AddScoped<IAnnouncementRepository, AnnouncementRepository>();

            return services;
        }
    }
}
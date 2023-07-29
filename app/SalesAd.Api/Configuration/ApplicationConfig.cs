using SalesAd.Application.UseCases.Announcement.CreateAnnouncementUseCase;
using SalesAd.Application.UseCases.Announcement.GetAllAnnouncementUseCase;
using SalesAd.Application.UseCases.Announcement.GetByIdAnnouncementUseCase;
using SalesAd.Application.UseCases.Announcement.GetByOwnerAnnouncementUseCase;
using SalesAd.Application.UseCases.Announcement.RemoveAnnouncementUseCase;
using SalesAd.Application.UseCases.Announcement.UpdateAnnouncementUseCase;
using SalesAd.Application.UseCases.Owner.ActiveOwnerUseCase;
using SalesAd.Application.UseCases.Owner.CreateOwnerUseCase;
using SalesAd.Application.UseCases.Owner.RemoveOwnerUseCase;
using SalesAd.Application.UseCases.Owner.UpdateOwnerUseCase;

namespace SalesAd.Api.Configuration
{
    public static class ApplicationConfig
    {
        public static IServiceCollection ConfigApplication(this IServiceCollection services)
        {
            services.AddScoped<ICreateAnnouncementUseCase, CreateAnnouncementUseCase>();
            services.AddScoped<IGetAllAnnouncementUseCase, GetAllAnnouncementUseCase>();
            services.AddScoped<IGetByIdAnnouncementUseCase, GetByIdAnnouncementUseCase>();
            services.AddScoped<IGetByOwnerAnnouncementUseCase, GetByOwnerAnnouncementUseCase>();
            services.AddScoped<IRemoveAnnouncementUseCase, RemoveAnnouncementUseCase>();
            services.AddScoped<IUpdateAnnouncementUseCase, UpdateAnnouncementUseCase>();

            services.AddScoped<IActiveOwnerUseCase, ActiveOwnerUseCase>();
            services.AddScoped<ICreateOwnerUseCase, CreateOwnerUseCase>();
            services.AddScoped<IRemoveOwnerUseCase, RemoveOwnerUseCase>();
            services.AddScoped<IUpdateOwnerUseCase, UpdateOwnerUseCase>();

            return services;
        }
    }
}
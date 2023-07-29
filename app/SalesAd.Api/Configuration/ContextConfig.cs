using Microsoft.EntityFrameworkCore;
using SalesAd.Infra.Context;

namespace SalesAd.Api.Configuration
{
    public static class ContextConfig
    {
        public static IServiceCollection ConfigContext(this IServiceCollection services, IConfiguration configuration)
        {
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            string? connectionString;
            if (env == "Release") connectionString = configuration.GetConnectionString("ReleaseConnection");
            else if (env == "Docker") connectionString = configuration.GetConnectionString("DockerConnection");
            else connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<DataContext>(
                options => options.UseNpgsql(connectionString)
            );

            services.AddHealthChecks()
                .AddNpgSql(connectionString ?? "", name: "Postgres SaledAd_DB");

            return services;
        }
    }
}
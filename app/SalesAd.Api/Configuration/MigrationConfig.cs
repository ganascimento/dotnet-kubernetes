using Microsoft.EntityFrameworkCore;
using SalesAd.Infra.Context;

namespace SalesAd.Api.Configuration
{
    public static class MigrationConfig
    {
        public static void ExecuteMigration(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var context = services.GetRequiredService<DataContext>();
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }
            }
        }
    }
}
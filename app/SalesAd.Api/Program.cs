using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.OpenApi.Models;
using SalesAd.Api.Configuration;

var builder = WebApplication.CreateBuilder(args);

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .ConfigApplication()
    .ConfigRepository()
    .ConfigContext(builder.Configuration)
    .ConfigCors();

builder.Services.AddHealthChecksUI(options =>
{
    options.SetEvaluationTimeInSeconds(5);
    options.MaximumHistoryEntriesPerEndpoint(10);
    string host = "/health";
    var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
    if (env == "Docker" || env == "Release")
        host = "http://localhost/health";

    options.AddHealthCheckEndpoint("API with Health Checks", host);
}).AddInMemoryStorage();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "HealthCheck", Version = "v1" });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.RoutePrefix = "swagger";
});
app.UseReDoc(c =>
{
    c.DocumentTitle = "Documento REDOC API";
    c.SpecUrl = "/swagger/v1/swagger.json";
    c.RoutePrefix = "/redoc";
});

app.UseHealthChecksUI(options => { options.UIPath = "/dashboard"; });
app.UseHttpsRedirection();
app.UseCors("CorsPolicy");
app.UseAuthorization();
app.MapControllers();

app.UseHealthChecks("/health", new HealthCheckOptions
{
    Predicate = p => true,
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});

app.UseHealthChecksUI(options => { options.UIPath = "/dashboard"; });

app.ExecuteMigration();

app.Run();

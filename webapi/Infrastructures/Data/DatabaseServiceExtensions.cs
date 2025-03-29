using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using System.Data;
using webapi.Infrastructures.Data;

namespace webapi.Infrastructures.Data;

public static class DatabaseServiceExtensions
{
    public static IServiceCollection AddDatabaseServices(
        this IServiceCollection services, 
        IConfiguration configuration)
    {
        // EF Core Configuration
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseNpgsql(
                configuration.GetConnectionString("DefaultConnection"),
                npgsqlOptions =>
                {
                    npgsqlOptions.EnableRetryOnFailure(
                        configuration.GetValue<int>("DatabaseOptions:MaxRetryCount"));
                    npgsqlOptions.CommandTimeout(
                        configuration.GetValue<int>("DatabaseOptions:CommandTimeout"));
                    npgsqlOptions.UseNodaTime();
                });
            
            if (configuration.GetValue<bool>("DatabaseOptions:EnableDetailedErrors"))
                options.EnableDetailedErrors();
            
            if (configuration.GetValue<bool>("DatabaseOptions:EnableSensitiveDataLogging"))
                options.EnableSensitiveDataLogging();
        });

        // Dapper Configuration
        services.AddTransient<IDbConnection>(_ => 
            new NpgsqlConnection(configuration.GetConnectionString("DapperConnection")));

        return services;
    }
}

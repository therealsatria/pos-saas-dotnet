using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // DbSets
    public DbSet<Tenant> Tenants => Set<Tenant>();
    public DbSet<Product> Products => Set<Product>();
    // Add other DbSets here...

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Configure decimal precision and UUID
        modelBuilder.HasPostgresExtension("uuid-ossp");
        
        // Apply all entity configurations
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }

    public async Task<IEnumerable<T>> QueryDapperAsync<T>(string sql, object? param = null)
    {
        await using var connection = Database.GetDbConnection();
        await connection.OpenAsync();
        return await connection.QueryAsync<T>(sql, param);
    }

    public async Task<int> ExecuteDapperAsync(string sql, object? param = null)
    {
        await using var connection = Database.GetDbConnection();
        await connection.OpenAsync();
        return await connection.ExecuteAsync(sql, param);
    }
}

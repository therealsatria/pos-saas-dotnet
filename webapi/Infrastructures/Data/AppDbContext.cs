using Microsoft.EntityFrameworkCore;
using Dapper;
using Infrastructures.Entities;

namespace Infrastructures.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // DbSets
    public DbSet<Tenant> Tenants => Set<Tenant>();
    public DbSet<Subscription> Subscriptions => Set<Subscription>();
    public DbSet<SubscriptionPlan> SubscriptionPlans => Set<SubscriptionPlan>();
    public DbSet<User> Users => Set<User>();
    public DbSet<Role> Roles => Set<Role>();
    public DbSet<RolePermission> RolePermissions => Set<RolePermission>();
    public DbSet<Permission> Permissions => Set<Permission>();
    public DbSet<UserRole> UserRoles => Set<UserRole>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<ProductCategory> ProductCategories => Set<ProductCategory>();
    public DbSet<Inventory> Inventories => Set<Inventory>();
    public DbSet<InventoryLog> InventoryLogs => Set<InventoryLog>();
    public DbSet<Supplier> Suppliers => Set<Supplier>();
    public DbSet<Sale> Sales => Set<Sale>();
    public DbSet<SaleItem> SaleItems => Set<SaleItem>();
    public DbSet<Payment> Payments => Set<Payment>();
    public DbSet<Tax> Taxes => Set<Tax>();
    public DbSet<Discount> Discounts => Set<Discount>();
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<LoyaltyProgram> LoyaltyPrograms => Set<LoyaltyProgram>();
    public DbSet<LoyaltyPoint> LoyaltyPoints => Set<LoyaltyPoint>();
    public DbSet<AuditLog> AuditLogs => Set<AuditLog>();
    public DbSet<Report> Reports => Set<Report>();
    public DbSet<PaymentGateway> PaymentGateways => Set<PaymentGateway>();
    public DbSet<TenantSetting> TenantSettings => Set<TenantSetting>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Configure decimal precision and UUID
        modelBuilder.HasPostgresExtension("uuid-ossp");

        // Configure relationships
        modelBuilder.Entity<Tenant>()
            .HasMany(t => t.Subscriptions)
            .WithOne(s => s.Tenant)
            .HasForeignKey(s => s.TenantId);

        modelBuilder.Entity<SubscriptionPlan>()
            .HasMany(sp => sp.Subscriptions)
            .WithOne(s => s.Plan)
            .HasForeignKey(s => s.PlanId);

        modelBuilder.Entity<User>()
            .HasMany(u => u.UserRoles)
            .WithOne(ur => ur.User)
            .HasForeignKey(ur => ur.UserId);

        modelBuilder.Entity<Role>()
            .HasMany(r => r.UserRoles)
            .WithOne(ur => ur.Role)
            .HasForeignKey(ur => ur.RoleId);

        modelBuilder.Entity<Role>()
            .HasMany(r => r.RolePermissions)
            .WithOne(rp => rp.Role)
            .HasForeignKey(rp => rp.RoleId);

        modelBuilder.Entity<Permission>()
            .HasMany(p => p.RolePermissions)
            .WithOne(rp => rp.Permission)
            .HasForeignKey(rp => rp.PermissionId);

        modelBuilder.Entity<Product>()
            .HasMany(p => p.ProductCategories)
            .WithOne(pc => pc.Product)
            .HasForeignKey(pc => pc.ProductId);

        modelBuilder.Entity<Category>()
            .HasMany(c => c.ProductCategories)
            .WithOne(pc => pc.Category)
            .HasForeignKey(pc => pc.CategoryId);

        modelBuilder.Entity<Category>()
            .HasOne(c => c.ParentCategory)
            .WithMany(c => c.ChildCategories)
            .HasForeignKey(c => c.ParentId);

        modelBuilder.Entity<Product>()
            .HasOne(p => p.Supplier)
            .WithMany()
            .HasForeignKey(p => p.SupplierId);

        modelBuilder.Entity<Product>()
            .HasOne(p => p.Inventory)
            .WithOne(i => i.Product)
            .HasForeignKey<Inventory>(i => i.ProductId);

        modelBuilder.Entity<Inventory>()
            .HasMany(i => i.InventoryLogs)
            .WithOne(il => il.Inventory)
            .HasForeignKey(il => il.InventoryId);

        modelBuilder.Entity<Sale>()
            .HasMany(s => s.SaleItems)
            .WithOne(si => si.Sale)
            .HasForeignKey(si => si.SaleId);

        modelBuilder.Entity<Sale>()
            .HasOne(s => s.Tax)
            .WithMany()
            .HasForeignKey(s => s.TaxId);

        modelBuilder.Entity<Sale>()
            .HasOne(s => s.Discount)
            .WithMany()
            .HasForeignKey(s => s.DiscountId);

        modelBuilder.Entity<Sale>()
            .HasOne(s => s.Payment)
            .WithOne(p => p.Sale)
            .HasForeignKey<Payment>(p => p.SaleId);

        modelBuilder.Entity<Customer>()
            .HasOne(c => c.LoyaltyPoints)
            .WithOne(lp => lp.Customer)
            .HasForeignKey<LoyaltyPoint>(lp => lp.CustomerId);

        modelBuilder.Entity<LoyaltyProgram>()
            .HasMany(lp => lp.LoyaltyPoints)
            .WithOne(lp => lp.LoyaltyProgram)
            .HasForeignKey(lp => lp.LoyaltyProgramId);

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

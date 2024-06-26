using KolokwiumDF.Configuration;
using Microsoft.EntityFrameworkCore;

namespace KolokwiumDF.Models;

public class Context : DbContext
{
    public Context() { }
    public Context(DbContextOptions<Context> options) : base(options) { }

    public virtual DbSet<Client> Clients { get; set; }
    public virtual DbSet<Sale> Sales { get; set; }
    public virtual DbSet<Subscription> Subscriptions { get; set; }
    public virtual DbSet<Discount> Discounts { get; set; }
    public virtual DbSet<Payment> Payments { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ClientConfig());
        modelBuilder.ApplyConfiguration(new SaleConfiguration());
        modelBuilder.ApplyConfiguration(new SubscriptionConfiguration());
        modelBuilder.ApplyConfiguration(new PaymentConfig());
        modelBuilder.ApplyConfiguration(new DiscountConfiguration());
        
    }
}
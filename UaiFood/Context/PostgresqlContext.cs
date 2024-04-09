using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using UaiFood.Models;

namespace UaiFood.Data;

public class PostgresqlContext : DbContext
{
    public PostgresqlContext(DbContextOptions<PostgresqlContext> options) : base(options)
    {
    }

    public DbSet<Store> Stores { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Bookmarked> Bookmarks { get; set; }
    public DbSet<AvaiabilityStores> AvaiableStores { get; set; }
}

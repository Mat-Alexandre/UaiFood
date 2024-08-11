using Microsoft.EntityFrameworkCore;
using UaiFood.Models;

namespace UaiFood.Context;

public class UaiFoodAppContext : DbContext
{
    public UaiFoodAppContext(DbContextOptions<UaiFoodAppContext> options) : base(options)
    {
    }

    public DbSet<Store> Stores { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Bookmarked> Bookmarks { get; set; }
    public DbSet<AvaiabilityStores> AvaiableStores { get; set; }
}

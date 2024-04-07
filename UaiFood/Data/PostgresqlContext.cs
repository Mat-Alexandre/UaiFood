using Microsoft.EntityFrameworkCore;
using UaiFood.Models;

namespace UaiFood.Data;

public class PostgresqlContext : DbContext
{
    public PostgresqlContext(DbContextOptions<PostgresqlContext> options) : base(options)
    {
    }

    public DbSet<Client> Clients { get; set; }
}

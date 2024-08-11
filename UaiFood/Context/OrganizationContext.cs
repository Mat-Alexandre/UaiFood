using Microsoft.EntityFrameworkCore;
using UaiFood.Models;

namespace UaiFood.Context;

public class OrganizationContext : DbContext
{
    public OrganizationContext(DbContextOptions<OrganizationContext> options) : base(options)
    {
    }

    public DbSet<OrganizationEmployee> Employees { get; set; }
}

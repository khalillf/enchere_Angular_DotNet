
using ENCHERE.model;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    // Add DbSet properties for other entity models, e.g., Products, Orders, etc.

    // Add any additional configuration or model mappings here.
}

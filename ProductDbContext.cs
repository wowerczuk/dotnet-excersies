using Microsoft.EntityFrameworkCore;

namespace Programowanie;

public class ProductDbContext : DbContext
{
    
    public DbSet<Product> Products { get; set; }

    public ProductDbContext(DbContextOptions options) : base(options) { }
   
}

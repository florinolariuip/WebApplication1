using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Paper> Papers => Set<Paper>();

}
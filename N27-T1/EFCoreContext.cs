using Microsoft.EntityFrameworkCore;

namespace N27_T1;

public class EFCoreContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql
            ("host=localhost;Port=7777;Username=postgres;Password=0814;Database=postgres;");
    
    public DbSet<Person> People { get; set; }
    
    
}
using Microsoft.EntityFrameworkCore;


namespace Semana09.Model
{
    public class SemanaContext : DbContext
    {
          public SemanaContext(DbContextOptions<SemanaContext> options) : base(options)
    {
        
    }
    public DbSet<SemanaModel> Semana { get; set; }  
    }
}
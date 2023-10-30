using libreriaa_PHAC.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace libreriaa_PHAC.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        { 
        
        }


        public DbSet<Book> Books { get; set; }
    }
}

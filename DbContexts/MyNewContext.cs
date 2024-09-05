

using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;

namespace WebApplication1.DbContexts
{
    public class MyNewContext : DbContext
    {
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Shop> Shops { get; set; }

        public MyNewContext(DbContextOptions options): base(options) { }
        
    }
    
}

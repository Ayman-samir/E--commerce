using Core.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public DbSet<Product>products { get; set; }
        public StoreContext(DbContextOptions<StoreContext> options): base(options)
        {
            
        }

    }
}

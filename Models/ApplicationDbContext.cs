using Microsoft.EntityFrameworkCore;

namespace ECommerceApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options
        ) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}

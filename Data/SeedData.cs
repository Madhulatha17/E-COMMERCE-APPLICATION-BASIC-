using ECommerceApp.Models;

namespace ECommerceApp.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Products.Any())
                return;

            context.Products.AddRange(
                new Product
                {
                    Name = "Laptop",
                    Description = "High Performance Laptop",
                    Price = 50000
                },
                new Product
                {
                    Name = "Smartphone",
                    Description = "Latest Smartphone",
                    Price = 25000
                },
                new Product
                {
                    Name = "Headphones",
                    Description = "Wireless Headphones",
                    Price = 3000
                }
            );

            context.SaveChanges();
        }
    }
}

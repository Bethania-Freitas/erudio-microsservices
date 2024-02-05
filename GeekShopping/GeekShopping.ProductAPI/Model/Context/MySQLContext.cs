using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {}

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }
        public DbSet<Product> Products { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Camiseta_OccupeMars",
                Price = new decimal(69.9).ToString(),
                Description = "Description",
                ImageURL = "https://github.com/Bethania-Freitas/erudio-microsservices/blob/main/ShoppingImages/11_mars.jpg",
                CategoryName = "T-shirt",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Millenium Falcom",
                Price = new decimal(469.9).ToString(),
                Description = "Description",
                ImageURL = "https://github.com/Bethania-Freitas/erudio-microsservices/blob/main/ShoppingImages/10_milennium_falcon.jpg?raw=true",
                CategoryName = "Tools",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Camiseta Gnu Linux",
                Price = new decimal(69.9).ToString(),
                Description = "Description",
                ImageURL = "https://github.com/Bethania-Freitas/erudio-microsservices/blob/main/ShoppingImages/12_gnu_linux.jpg?raw=true",
                CategoryName = "T-shirt",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Camiseta Dragon Ball",
                Price = new decimal(59.9).ToString(),
                Description = "Description",
                ImageURL = "https://github.com/Bethania-Freitas/erudio-microsservices/blob/main/ShoppingImages/13_dragon_ball.jpg?raw=true",
                CategoryName = "T-shirt",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Patch Nasa",
                Price = new decimal(29.9).ToString(),
                Description = "Description",
                ImageURL = "https://github.com/Bethania-Freitas/erudio-microsservices/blob/main/ShoppingImages/14_patch_nasa.jpg?raw=true",
                CategoryName = "Tools",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Caneca Mario",
                Price = new decimal(29.9).ToString(),
                Description = "Description",
                ImageURL = "https://github.com/Bethania-Freitas/erudio-microsservices/blob/main/ShoppingImages/1_super_mario.jpg?raw=true",
                CategoryName = "Tools",
            });
        }
    }
}

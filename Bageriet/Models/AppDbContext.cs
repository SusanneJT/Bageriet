using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Bread> Bread { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 1, ProductName = "Bröd", Description = "Nybakat bröd som passar lika bra till frukost som till lunch" });
            

            //seed pies

            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 1,
                Name = "Rågbröd",
                Price = 12.95M,
                ShortDescription = "Lorem ipsum dolor sit amet, consectem arcu, interdum vel accumsan vitae, lobortis.",
                LongDescription =
                    "Rågbrödet med consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                ProductId = 1,
                ImageUrl = "/Images/bread1.jpg",
                InStock = true,
            });

            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 2,
                Name = "Höstbröd",
                Price = 11.95M,
                ShortDescription = "Lorem ipsum dolor sit amet, consectem arcu, interdum vel accumsan vitae, lobortis.",
                LongDescription =
                    "Höstbrödet med consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                ProductId = 1,
                ImageUrl = "/Images/bread2.jpg",
                InStock = true,
            });

            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 3,
                Name = "Fröbröd",
                Price = 13.95M,
                ShortDescription = "Lorem ipsum dolor sit amet, consectem arcu, interdum vel accumsan vitae, lobortis.",
                LongDescription =
                    "Fröbrödbrödet med consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                ProductId = 1,
                ImageUrl = "/Images/bread3.jpg",
                InStock = true,
            });

            modelBuilder.Entity<Bread>().HasData(new Bread
            {
                BreadId = 4,
                Name = "Baguette",
                Price = 9.95M,
                ShortDescription = "Lorem ipsum dolor sit amet, consectem arcu, interdum vel accumsan vitae, lobortis.",
                LongDescription =
                 "Baguetten med consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                ProductId = 1,
                ImageUrl = "/Images/bread4.jpg",
                InStock = true,
            });

        }

    }
}

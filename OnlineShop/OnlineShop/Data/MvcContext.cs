using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data
{
    public class MvcContext:DbContext
    {
        public MvcContext(DbContextOptions<MvcContext> options)
               : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User_Role>()
                .HasOne(u => u.User)
                .WithMany(ui => ui.User_Roles)
                .HasForeignKey(id => id.UserId);
            builder.Entity<User_Role>()
                .HasOne(u => u.Role)
                .WithMany(ui => ui.User_Roles)
                .HasForeignKey(id => id.RoleId);
            builder.Entity<Country>()
                .HasMany(b => b.Brands)
                .WithOne(e => e.Country);
            builder.Entity<Brand>()
                .HasMany(b => b.Items)
                .WithOne(e => e.Brand);
            builder.Entity<Item_Category>()
                .HasOne(i => i.Category)
                .WithMany(ic => ic.Item_Categories)
                .HasForeignKey(id => id.CategoryId);
            builder.Entity<Item_Category>()
               .HasOne(i => i.Item)
               .WithMany(ic => ic.Item_Categories)
               .HasForeignKey(id => id.ItemId);

        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Country> Countries { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User_Role> User_Roles { get; set; }

        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item_Category> Item_Categories { get; set; }
    }
}

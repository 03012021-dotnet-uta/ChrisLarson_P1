using ChrisLarson_P1.Models;
using Microsoft.EntityFrameworkCore;
using Models;
using TreeShop.Models;

namespace ChrisLarson_P1.Repository
{
    public class TreeShopContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Tree> Trees { get; set; }
        public DbSet<Order> Order { get; set; }
        
        public TreeShopContext(DbContextOptions<TreeShopContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(Configuration.GetConectionString("treeDb"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasKey(c => new { c.CustomerId, c.TreeId });
        }
    }
}
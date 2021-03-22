using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BurgerStore.Data
{
    public class BurgerStoreContext : DbContext
    {
        public BurgerStoreContext(DbContextOptions<BurgerStoreContext> options) : base(options)
        {
        }

        public DbSet<Bun> Buns { get; set; }
        public DbSet<Patty> Patties { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Burger> Burgers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bun>().ToTable("Bun");
            modelBuilder.Entity<Patty>().ToTable("Patty");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Burger>().ToTable("Burger");
        }
    }
}

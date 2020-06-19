using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Warehouse
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Storаge> Storаges { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Stat> Stats { get; set; }

        public ApplicationContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=warehouse;Username=postgres;Password=123123");
        }
    }
}


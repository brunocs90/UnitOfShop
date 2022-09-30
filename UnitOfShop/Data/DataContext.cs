using Microsoft.EntityFrameworkCore;
using UnitOfShop.Models;

namespace UnitOfShop.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {                
        }
        public DbSet<Customer>  Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

    }
}

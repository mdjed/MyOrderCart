using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOrderCart.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        { 

        }
        public DbSet<Product> Customers { get; set; }
        public DbSet<Order> Invoices { get; set; }
        public DbSet<Cart> InvoiceItems { get; set; }

    }
}

//using MySql.Data.EntityFramework;
//using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using OrderManage.Models;
using Microsoft.EntityFrameworkCore;

namespace OrderAPI.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Client> Customers { get; set; }
    }   
}
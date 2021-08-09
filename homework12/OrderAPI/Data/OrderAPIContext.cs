using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderManage.Models;

namespace OrderAPI.Data
{
    public class OrderAPIContext : DbContext
    {
        public OrderAPIContext (DbContextOptions<OrderAPIContext> options)
            : base(options)
        {
        }

        public DbSet<OrderManage.Models.Client> Client { get; set; }

        public DbSet<OrderManage.Models.Order> Order { get; set; }

        public DbSet<OrderManage.Models.OrderService> OrderService { get; set; }
    }
}

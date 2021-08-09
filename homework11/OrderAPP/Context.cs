using MySql.Data.EntityFramework;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using 订单管理;

namespace OrderApp {
  
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class Context: DbContext{
        public Context() : base("db_order"){
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
        }
        
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Client> Customers { get; set; }
    }
}
using System;
using ��������;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using MySql.Data.EntityFramework;


namespace OrderAPP
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public partial class Model1 : DbContext//���ݿ��������
    {
        public Model1()
            : base("db_order")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Model1>());
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Client> Customers { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Risus.Entities;
using SQLite.CodeFirst;

namespace Risus.DbLayer
{
  class RisusContext : DbContext
  {
    public RisusContext() : base("RisusContext")
    {

    }

    public DbSet<Customer> Customers
    {
      get;
      set;
    }

    public DbSet<Product> Products
    {
      get;
      set;
    }

    public DbSet<Order> Orders
    {
      get;
      set;
    }

    public DbSet<SpecialOrder> SpecialOrders
    {
      get;
      set;
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<RisusContext>(modelBuilder);
      Database.SetInitializer(sqliteConnectionInitializer);
    }
  }
}
using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.ComponentModel;
using DevExpress.ExpressApp.EF.Updating;
using DevExpress.Persistent.BaseImpl.EF;

namespace  Risus.Module.BusinessObjects {
	public class RisusDbContext : DbContext {
		public RisusDbContext(String connectionString)
			: base(connectionString) {
		}
		public RisusDbContext(DbConnection connection)
			: base(connection, false) {
		}
		public DbSet<ModuleInfo> ModulesInfo { get; set; }

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
	}
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Risus.DbLayer;
using Risus.Entities;

namespace RisusTests
{
  [TestClass]
  public class RisusContextTests
  {
    [TestMethod]
    public void TestNewCustomer()
    {
      using (var db = new RisusContext())
      {
        Customer customer = new Customer()
        {
          Id = 1,
          DateOfBirth = new DateTime(1975, 4, 18),
          DateOfMarriage = new DateTime(2008, 5, 11)
        };
        customer.Name = "Tekin";
        db.Customers.Add(customer);
        db.SaveChanges();
      }
    }
  }
}

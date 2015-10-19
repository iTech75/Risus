using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risus.Entities
{
  class Customer
  {
    public int Id
    {
      get;
      set;
    }

    public string Name
    {
      get;
      set;
    }

    public string Surname
    {
      get;
      set;
    }

    public DateTime DateOfBirth
    {
      get;
      set;
    }

    public DateTime DateOfMarriage
    {
      get;
      set;
    }

    public string Address
    {
      get;
      set;
    }

    public string MobilePhone
    {
      get;
      set;
    }

    public string HomePhone
    {
      get;
      set;
    }

    public string Email
    {
      get;
      set;
    }

    public int RingSize
    {
      get;
      set;
    }

    public string SpouseName
    {
      get;
      set;
    }

    public string ChildrenNames
    {
      get;
      set;
    }

    public virtual List<Order> Orders
    {
      get;
      set;
    }
  }
}
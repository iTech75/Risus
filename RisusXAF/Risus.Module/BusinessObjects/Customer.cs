using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;

namespace Risus.Module.BusinessObjects
{
  [NavigationItem("Bilgi Ekranları")]
  public class Customer
  {
    [Browsable(false)]
    public int Id
    {
      get;
      protected set;
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

    [FieldSize(512)]
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
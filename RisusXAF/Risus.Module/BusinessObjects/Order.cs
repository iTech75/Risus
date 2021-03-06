﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Persistent.Base;

namespace Risus.Module.BusinessObjects
{
  [NavigationItem("Bilgi Ekranları")]
  public class Order
  {
    [Browsable(false)]
    public int Id
    {
      get;
      protected set;
    }

    public int CustomerId
    {
      get;
      set;
    }

    public int ProductId
    {
      get;
      set;
    }

    public DateTime DateOfOrder
    {
      get;
      set;
    }

    public virtual Customer Customer
    {
      get;
      set;
    }

    public virtual Product Product
    {
      get;
      set;
    }
  }
}
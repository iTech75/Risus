﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risus.Entities
{
  class Order
  {
    public int Id
    {
      get;
      set;
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
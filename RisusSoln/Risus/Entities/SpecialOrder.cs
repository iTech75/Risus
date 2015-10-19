using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Risus.Entities
{
  class SpecialOrder
  {
    public int Id
    {
      get;
      set;
    }

    public string Description
    {
      get;
      set;
    }

    public decimal Price
    {
      get;
      set;
    }

    public bool USD
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
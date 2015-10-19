using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risus.Entities
{
  class Product
  {
    public string Id
    {
      get;
      set;
    }

    public string Type
    {
      get;
      set;
    }

    public decimal M
    {
      get;
      set;
    }

    public decimal S
    {
      get;
      set;
    }

    public decimal K
    {
      get;
      set;
    }

    public byte[] Image
    {
      get;
      set;
    }

    public string MLID
    {
      get;
      set;
    }

    public virtual List<SpecialOrder> SpecialOrders
    {
      get;
      set;
    }
  }
}
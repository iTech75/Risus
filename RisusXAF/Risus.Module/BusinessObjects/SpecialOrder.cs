using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using DevExpress.Persistent.Base;

namespace Risus.Module.BusinessObjects
{
  [NavigationItem("Bilgi Ekranları")]
  public class SpecialOrder
  {
    [Browsable(false)]
    public int Id
    {
      get;
      protected set;
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
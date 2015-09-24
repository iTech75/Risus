using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace Risus.Module.BusinessObjects
{
  [NavigationItem("Bilgi Ekranları")]
  public class Product
  {
    [Browsable(false)]
    public string Id
    {
      get;
      protected set;
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

    [ImageEditor(ListViewImageEditorCustomHeight = 75, DetailViewImageEditorFixedHeight = 150)]
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

    [Aggregated]
    public virtual IList<SpecialOrder> SpecialOrders
    {
      get;
      set;
    }
  }
}
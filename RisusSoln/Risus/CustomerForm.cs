using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Risus.DbLayer;
using System.Data.Entity;

namespace Risus
{
  public partial class CustomerForm : Form
  {
    RisusContext context;

    public CustomerForm()
    {
      InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      context = new RisusContext();
      context.Customers.Load();
      customerBindingSource.DataSource = context.Customers.Local;
    }

    private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      context.SaveChanges();
    }

    protected override void OnClosing(CancelEventArgs e)
    {
      base.OnClosing(e);
      context.Dispose();
    }
  }
}
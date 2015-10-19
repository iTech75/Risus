using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risus
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void customerMenu_Click(object sender, EventArgs e)
    {
      CustomerForm form = new CustomerForm();
      form.ShowDialog();
    }
  }
}

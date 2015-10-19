namespace Risus
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.customerMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.productMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.orderMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.programSonuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.işlemlerToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(686, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // dosyaToolStripMenuItem
      // 
      this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programSonuToolStripMenuItem});
      this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
      this.dosyaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
      this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
      this.dosyaToolStripMenuItem.Text = "&Dosya";
      // 
      // işlemlerToolStripMenuItem
      // 
      this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerMenu,
            this.productMenu,
            this.orderMenu});
      this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
      this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
      this.işlemlerToolStripMenuItem.Text = "&İşlemler";
      // 
      // customerMenu
      // 
      this.customerMenu.Name = "customerMenu";
      this.customerMenu.Size = new System.Drawing.Size(152, 22);
      this.customerMenu.Text = "&Müşteri Ekranı";
      this.customerMenu.Click += new System.EventHandler(this.customerMenu_Click);
      // 
      // productMenu
      // 
      this.productMenu.Name = "productMenu";
      this.productMenu.Size = new System.Drawing.Size(152, 22);
      this.productMenu.Text = "&Ürün Ekranı";
      // 
      // orderMenu
      // 
      this.orderMenu.Name = "orderMenu";
      this.orderMenu.Size = new System.Drawing.Size(152, 22);
      this.orderMenu.Text = "&Sipariş Ekranı";
      // 
      // programSonuToolStripMenuItem
      // 
      this.programSonuToolStripMenuItem.Name = "programSonuToolStripMenuItem";
      this.programSonuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.programSonuToolStripMenuItem.Text = "Program &Sonu";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(686, 360);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Risus Artun";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem programSonuToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem customerMenu;
    private System.Windows.Forms.ToolStripMenuItem productMenu;
    private System.Windows.Forms.ToolStripMenuItem orderMenu;
  }
}


namespace Risus
{
  partial class ProductForm
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
      System.Windows.Forms.Label idLabel;
      System.Windows.Forms.Label kLabel;
      System.Windows.Forms.Label mLabel;
      System.Windows.Forms.Label mLIDLabel;
      System.Windows.Forms.Label sLabel;
      System.Windows.Forms.Label typeLabel;
      this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.productBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.idTextBox = new System.Windows.Forms.TextBox();
      this.kTextBox = new System.Windows.Forms.TextBox();
      this.mTextBox = new System.Windows.Forms.TextBox();
      this.mLIDTextBox = new System.Windows.Forms.TextBox();
      this.sTextBox = new System.Windows.Forms.TextBox();
      this.typeTextBox = new System.Windows.Forms.TextBox();
      idLabel = new System.Windows.Forms.Label();
      kLabel = new System.Windows.Forms.Label();
      mLabel = new System.Windows.Forms.Label();
      mLIDLabel = new System.Windows.Forms.Label();
      sLabel = new System.Windows.Forms.Label();
      typeLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
      this.productBindingNavigator.SuspendLayout();
      this.SuspendLayout();
      // 
      // productBindingSource
      // 
      this.productBindingSource.DataSource = typeof(Risus.Entities.Product);
      // 
      // productBindingNavigator
      // 
      this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.productBindingNavigator.BindingSource = this.productBindingSource;
      this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.productBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productBindingNavigatorSaveItem});
      this.productBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.productBindingNavigator.Name = "productBindingNavigator";
      this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.productBindingNavigator.Size = new System.Drawing.Size(325, 25);
      this.productBindingNavigator.TabIndex = 0;
      this.productBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Current position";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      // 
      // productBindingNavigatorSaveItem
      // 
      this.productBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.productBindingNavigatorSaveItem.Enabled = false;
      this.productBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productBindingNavigatorSaveItem.Image")));
      this.productBindingNavigatorSaveItem.Name = "productBindingNavigatorSaveItem";
      this.productBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
      this.productBindingNavigatorSaveItem.Text = "Save Data";
      // 
      // idLabel
      // 
      idLabel.AutoSize = true;
      idLabel.Location = new System.Drawing.Point(49, 52);
      idLabel.Name = "idLabel";
      idLabel.Size = new System.Drawing.Size(19, 13);
      idLabel.TabIndex = 1;
      idLabel.Text = "Id:";
      // 
      // idTextBox
      // 
      this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Id", true));
      this.idTextBox.Location = new System.Drawing.Point(91, 49);
      this.idTextBox.Name = "idTextBox";
      this.idTextBox.Size = new System.Drawing.Size(100, 20);
      this.idTextBox.TabIndex = 2;
      // 
      // kLabel
      // 
      kLabel.AutoSize = true;
      kLabel.Location = new System.Drawing.Point(49, 78);
      kLabel.Name = "kLabel";
      kLabel.Size = new System.Drawing.Size(17, 13);
      kLabel.TabIndex = 3;
      kLabel.Text = "K:";
      // 
      // kTextBox
      // 
      this.kTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "K", true));
      this.kTextBox.Location = new System.Drawing.Point(91, 75);
      this.kTextBox.Name = "kTextBox";
      this.kTextBox.Size = new System.Drawing.Size(100, 20);
      this.kTextBox.TabIndex = 4;
      // 
      // mLabel
      // 
      mLabel.AutoSize = true;
      mLabel.Location = new System.Drawing.Point(49, 104);
      mLabel.Name = "mLabel";
      mLabel.Size = new System.Drawing.Size(19, 13);
      mLabel.TabIndex = 5;
      mLabel.Text = "M:";
      // 
      // mTextBox
      // 
      this.mTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "M", true));
      this.mTextBox.Location = new System.Drawing.Point(91, 101);
      this.mTextBox.Name = "mTextBox";
      this.mTextBox.Size = new System.Drawing.Size(100, 20);
      this.mTextBox.TabIndex = 6;
      // 
      // mLIDLabel
      // 
      mLIDLabel.AutoSize = true;
      mLIDLabel.Location = new System.Drawing.Point(49, 130);
      mLIDLabel.Name = "mLIDLabel";
      mLIDLabel.Size = new System.Drawing.Size(36, 13);
      mLIDLabel.TabIndex = 7;
      mLIDLabel.Text = "MLID:";
      // 
      // mLIDTextBox
      // 
      this.mLIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "MLID", true));
      this.mLIDTextBox.Location = new System.Drawing.Point(91, 127);
      this.mLIDTextBox.Name = "mLIDTextBox";
      this.mLIDTextBox.Size = new System.Drawing.Size(100, 20);
      this.mLIDTextBox.TabIndex = 8;
      // 
      // sLabel
      // 
      sLabel.AutoSize = true;
      sLabel.Location = new System.Drawing.Point(49, 156);
      sLabel.Name = "sLabel";
      sLabel.Size = new System.Drawing.Size(17, 13);
      sLabel.TabIndex = 9;
      sLabel.Text = "S:";
      // 
      // sTextBox
      // 
      this.sTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "S", true));
      this.sTextBox.Location = new System.Drawing.Point(91, 153);
      this.sTextBox.Name = "sTextBox";
      this.sTextBox.Size = new System.Drawing.Size(100, 20);
      this.sTextBox.TabIndex = 10;
      // 
      // typeLabel
      // 
      typeLabel.AutoSize = true;
      typeLabel.Location = new System.Drawing.Point(49, 182);
      typeLabel.Name = "typeLabel";
      typeLabel.Size = new System.Drawing.Size(34, 13);
      typeLabel.TabIndex = 11;
      typeLabel.Text = "Type:";
      // 
      // typeTextBox
      // 
      this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Type", true));
      this.typeTextBox.Location = new System.Drawing.Point(91, 179);
      this.typeTextBox.Name = "typeTextBox";
      this.typeTextBox.Size = new System.Drawing.Size(100, 20);
      this.typeTextBox.TabIndex = 12;
      // 
      // ProductForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(325, 241);
      this.Controls.Add(idLabel);
      this.Controls.Add(this.idTextBox);
      this.Controls.Add(kLabel);
      this.Controls.Add(this.kTextBox);
      this.Controls.Add(mLabel);
      this.Controls.Add(this.mTextBox);
      this.Controls.Add(mLIDLabel);
      this.Controls.Add(this.mLIDTextBox);
      this.Controls.Add(sLabel);
      this.Controls.Add(this.sTextBox);
      this.Controls.Add(typeLabel);
      this.Controls.Add(this.typeTextBox);
      this.Controls.Add(this.productBindingNavigator);
      this.Name = "ProductForm";
      this.Text = "ProductForm";
      ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
      this.productBindingNavigator.ResumeLayout(false);
      this.productBindingNavigator.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingSource productBindingSource;
    private System.Windows.Forms.BindingNavigator productBindingNavigator;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    private System.Windows.Forms.ToolStripButton productBindingNavigatorSaveItem;
    private System.Windows.Forms.TextBox idTextBox;
    private System.Windows.Forms.TextBox kTextBox;
    private System.Windows.Forms.TextBox mTextBox;
    private System.Windows.Forms.TextBox mLIDTextBox;
    private System.Windows.Forms.TextBox sTextBox;
    private System.Windows.Forms.TextBox typeTextBox;

  }
}
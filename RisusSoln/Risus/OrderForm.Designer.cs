namespace Risus
{
  partial class OrderForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
      System.Windows.Forms.Label customerIdLabel;
      System.Windows.Forms.Label dateOfOrderLabel;
      System.Windows.Forms.Label idLabel;
      System.Windows.Forms.Label productIdLabel;
      this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.orderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
      this.orderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.customerIdTextBox = new System.Windows.Forms.TextBox();
      this.dateOfOrderDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.idTextBox = new System.Windows.Forms.TextBox();
      this.productIdTextBox = new System.Windows.Forms.TextBox();
      customerIdLabel = new System.Windows.Forms.Label();
      dateOfOrderLabel = new System.Windows.Forms.Label();
      idLabel = new System.Windows.Forms.Label();
      productIdLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).BeginInit();
      this.orderBindingNavigator.SuspendLayout();
      this.SuspendLayout();
      // 
      // orderBindingSource
      // 
      this.orderBindingSource.DataSource = typeof(Risus.Entities.Order);
      // 
      // orderBindingNavigator
      // 
      this.orderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.orderBindingNavigator.BindingSource = this.orderBindingSource;
      this.orderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.orderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.orderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.orderBindingNavigatorSaveItem});
      this.orderBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.orderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.orderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.orderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.orderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.orderBindingNavigator.Name = "orderBindingNavigator";
      this.orderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.orderBindingNavigator.Size = new System.Drawing.Size(360, 25);
      this.orderBindingNavigator.TabIndex = 0;
      this.orderBindingNavigator.Text = "bindingNavigator1";
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
      // orderBindingNavigatorSaveItem
      // 
      this.orderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.orderBindingNavigatorSaveItem.Enabled = false;
      this.orderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orderBindingNavigatorSaveItem.Image")));
      this.orderBindingNavigatorSaveItem.Name = "orderBindingNavigatorSaveItem";
      this.orderBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
      this.orderBindingNavigatorSaveItem.Text = "Save Data";
      // 
      // customerIdLabel
      // 
      customerIdLabel.AutoSize = true;
      customerIdLabel.Location = new System.Drawing.Point(36, 51);
      customerIdLabel.Name = "customerIdLabel";
      customerIdLabel.Size = new System.Drawing.Size(66, 13);
      customerIdLabel.TabIndex = 1;
      customerIdLabel.Text = "Customer Id:";
      // 
      // customerIdTextBox
      // 
      this.customerIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "CustomerId", true));
      this.customerIdTextBox.Location = new System.Drawing.Point(118, 48);
      this.customerIdTextBox.Name = "customerIdTextBox";
      this.customerIdTextBox.Size = new System.Drawing.Size(200, 20);
      this.customerIdTextBox.TabIndex = 2;
      // 
      // dateOfOrderLabel
      // 
      dateOfOrderLabel.AutoSize = true;
      dateOfOrderLabel.Location = new System.Drawing.Point(36, 78);
      dateOfOrderLabel.Name = "dateOfOrderLabel";
      dateOfOrderLabel.Size = new System.Drawing.Size(76, 13);
      dateOfOrderLabel.TabIndex = 3;
      dateOfOrderLabel.Text = "Date Of Order:";
      // 
      // dateOfOrderDateTimePicker
      // 
      this.dateOfOrderDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "DateOfOrder", true));
      this.dateOfOrderDateTimePicker.Location = new System.Drawing.Point(118, 74);
      this.dateOfOrderDateTimePicker.Name = "dateOfOrderDateTimePicker";
      this.dateOfOrderDateTimePicker.Size = new System.Drawing.Size(200, 20);
      this.dateOfOrderDateTimePicker.TabIndex = 4;
      // 
      // idLabel
      // 
      idLabel.AutoSize = true;
      idLabel.Location = new System.Drawing.Point(36, 103);
      idLabel.Name = "idLabel";
      idLabel.Size = new System.Drawing.Size(19, 13);
      idLabel.TabIndex = 5;
      idLabel.Text = "Id:";
      // 
      // idTextBox
      // 
      this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Id", true));
      this.idTextBox.Location = new System.Drawing.Point(118, 100);
      this.idTextBox.Name = "idTextBox";
      this.idTextBox.Size = new System.Drawing.Size(200, 20);
      this.idTextBox.TabIndex = 6;
      // 
      // productIdLabel
      // 
      productIdLabel.AutoSize = true;
      productIdLabel.Location = new System.Drawing.Point(36, 129);
      productIdLabel.Name = "productIdLabel";
      productIdLabel.Size = new System.Drawing.Size(59, 13);
      productIdLabel.TabIndex = 7;
      productIdLabel.Text = "Product Id:";
      // 
      // productIdTextBox
      // 
      this.productIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "ProductId", true));
      this.productIdTextBox.Location = new System.Drawing.Point(118, 126);
      this.productIdTextBox.Name = "productIdTextBox";
      this.productIdTextBox.Size = new System.Drawing.Size(200, 20);
      this.productIdTextBox.TabIndex = 8;
      // 
      // OrderForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(360, 201);
      this.Controls.Add(customerIdLabel);
      this.Controls.Add(this.customerIdTextBox);
      this.Controls.Add(dateOfOrderLabel);
      this.Controls.Add(this.dateOfOrderDateTimePicker);
      this.Controls.Add(idLabel);
      this.Controls.Add(this.idTextBox);
      this.Controls.Add(productIdLabel);
      this.Controls.Add(this.productIdTextBox);
      this.Controls.Add(this.orderBindingNavigator);
      this.Name = "OrderForm";
      this.Text = "OrderForm";
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).EndInit();
      this.orderBindingNavigator.ResumeLayout(false);
      this.orderBindingNavigator.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingSource orderBindingSource;
    private System.Windows.Forms.BindingNavigator orderBindingNavigator;
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
    private System.Windows.Forms.ToolStripButton orderBindingNavigatorSaveItem;
    private System.Windows.Forms.TextBox customerIdTextBox;
    private System.Windows.Forms.DateTimePicker dateOfOrderDateTimePicker;
    private System.Windows.Forms.TextBox idTextBox;
    private System.Windows.Forms.TextBox productIdTextBox;

  }
}
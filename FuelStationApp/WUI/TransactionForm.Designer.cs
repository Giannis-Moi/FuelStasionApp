
namespace FuelStationApp.WUI {
    partial class TransactionForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gridViewItems = new DevExpress.XtraGrid.GridControl();
            this.gridViewListItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIItemType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTransactionLine = new DevExpress.XtraGrid.GridControl();
            this.gridViewTransactionLine = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldIDD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlCustomerID = new DevExpress.XtraEditors.TextEdit();
            this.labelcontrolCustomer = new DevExpress.XtraEditors.LabelControl();
            this.btnAddItem = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlDiscountValue = new DevExpress.XtraEditors.TextEdit();
            this.ctrlTotalValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlTotalCost = new DevExpress.XtraEditors.TextEdit();
            this.ctrlQuantity2 = new DevExpress.XtraEditors.SpinEdit();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransactionLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDiscountValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlQuantity2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewItems
            // 
            this.gridViewItems.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridViewItems.Location = new System.Drawing.Point(16, 107);
            this.gridViewItems.MainView = this.gridViewListItems;
            this.gridViewItems.Margin = new System.Windows.Forms.Padding(4);
            this.gridViewItems.Name = "gridViewItems";
            this.gridViewItems.Size = new System.Drawing.Size(649, 418);
            this.gridViewItems.TabIndex = 19;
            this.gridViewItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewListItems});
            this.gridViewItems.Click += new System.EventHandler(this.gridViewItems_Click);
            // 
            // gridViewListItems
            // 
            this.gridViewListItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCode,
            this.colDescription,
            this.colIItemType,
            this.colPrice,
            this.colCost});
            this.gridViewListItems.DetailHeight = 431;
            this.gridViewListItems.GridControl = this.gridViewItems;
            this.gridViewListItems.Name = "gridViewListItems";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 27;
            this.colID.Name = "colID";
            this.colID.Width = 100;
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.MinWidth = 27;
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 100;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 27;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 100;
            // 
            // colIItemType
            // 
            this.colIItemType.FieldName = "ItemType";
            this.colIItemType.MinWidth = 27;
            this.colIItemType.Name = "colIItemType";
            this.colIItemType.Visible = true;
            this.colIItemType.VisibleIndex = 2;
            this.colIItemType.Width = 100;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.MinWidth = 27;
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            this.colPrice.Width = 100;
            // 
            // colCost
            // 
            this.colCost.FieldName = "Cost";
            this.colCost.MinWidth = 27;
            this.colCost.Name = "colCost";
            this.colCost.Visible = true;
            this.colCost.VisibleIndex = 4;
            this.colCost.Width = 100;
            // 
            // gridTransactionLine
            // 
            this.gridTransactionLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTransactionLine.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridTransactionLine.Location = new System.Drawing.Point(825, 107);
            this.gridTransactionLine.MainView = this.gridViewTransactionLine;
            this.gridTransactionLine.Margin = new System.Windows.Forms.Padding(4);
            this.gridTransactionLine.Name = "gridTransactionLine";
            this.gridTransactionLine.Size = new System.Drawing.Size(649, 418);
            this.gridTransactionLine.TabIndex = 21;
            this.gridTransactionLine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTransactionLine});
            // 
            // gridViewTransactionLine
            // 
            this.gridViewTransactionLine.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemID,
            this.colQuantity,
            this.colItemPrice,
            this.colValue,
            this.gridColumn1,
            this.colItemType,
            this.coldIDD,
            this.colTransID});
            this.gridViewTransactionLine.DetailHeight = 431;
            this.gridViewTransactionLine.GridControl = this.gridTransactionLine;
            this.gridViewTransactionLine.Name = "gridViewTransactionLine";
            // 
            // colItemID
            // 
            this.colItemID.FieldName = "ItemID";
            this.colItemID.MinWidth = 27;
            this.colItemID.Name = "colItemID";
            this.colItemID.Width = 100;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MinWidth = 27;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 0;
            this.colQuantity.Width = 100;
            // 
            // colItemPrice
            // 
            this.colItemPrice.FieldName = "ItemPrice";
            this.colItemPrice.MinWidth = 27;
            this.colItemPrice.Name = "colItemPrice";
            this.colItemPrice.Visible = true;
            this.colItemPrice.VisibleIndex = 1;
            this.colItemPrice.Width = 100;
            // 
            // colValue
            // 
            this.colValue.FieldName = "Value";
            this.colValue.MinWidth = 27;
            this.colValue.Name = "colValue";
            this.colValue.Visible = true;
            this.colValue.VisibleIndex = 2;
            this.colValue.Width = 100;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Cost";
            this.gridColumn1.MinWidth = 27;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 100;
            // 
            // colItemType
            // 
            this.colItemType.FieldName = "ItemType";
            this.colItemType.MinWidth = 27;
            this.colItemType.Name = "colItemType";
            this.colItemType.Visible = true;
            this.colItemType.VisibleIndex = 4;
            this.colItemType.Width = 100;
            // 
            // coldIDD
            // 
            this.coldIDD.Caption = "ColID";
            this.coldIDD.MinWidth = 25;
            this.coldIDD.Name = "coldIDD";
            this.coldIDD.Width = 94;
            // 
            // colTransID
            // 
            this.colTransID.Caption = "TransactionID";
            this.colTransID.MinWidth = 25;
            this.colTransID.Name = "colTransID";
            this.colTransID.Width = 94;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl1.AppearancePressed.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(452, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(468, 29);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Transaction Form Management System";
            // 
            // ctrlCustomerID
            // 
            this.ctrlCustomerID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlCustomerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlCustomerID.EditValue = "";
            this.ctrlCustomerID.Enabled = false;
            this.ctrlCustomerID.Location = new System.Drawing.Point(216, 68);
            this.ctrlCustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlCustomerID.Name = "ctrlCustomerID";
            this.ctrlCustomerID.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlCustomerID.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlCustomerID.Properties.Appearance.ForeColor = System.Drawing.Color.SkyBlue;
            this.ctrlCustomerID.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlCustomerID.Properties.Appearance.Options.UseFont = true;
            this.ctrlCustomerID.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlCustomerID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlCustomerID.Size = new System.Drawing.Size(449, 28);
            this.ctrlCustomerID.TabIndex = 90;
            this.ctrlCustomerID.Visible = false;
            // 
            // labelcontrolCustomer
            // 
            this.labelcontrolCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelcontrolCustomer.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelcontrolCustomer.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelcontrolCustomer.Appearance.Options.UseFont = true;
            this.labelcontrolCustomer.Appearance.Options.UseForeColor = true;
            this.labelcontrolCustomer.Location = new System.Drawing.Point(16, 70);
            this.labelcontrolCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.labelcontrolCustomer.Name = "labelcontrolCustomer";
            this.labelcontrolCustomer.Size = new System.Drawing.Size(180, 23);
            this.labelcontrolCustomer.TabIndex = 92;
            this.labelcontrolCustomer.Text = "Your Customer ID is:";
            this.labelcontrolCustomer.Visible = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddItem.Appearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddItem.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnAddItem.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Appearance.Options.UseBackColor = true;
            this.btnAddItem.Appearance.Options.UseBorderColor = true;
            this.btnAddItem.Appearance.Options.UseFont = true;
            this.btnAddItem.Appearance.Options.UseForeColor = true;
            this.btnAddItem.Location = new System.Drawing.Point(692, 263);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(113, 34);
            this.btnAddItem.TabIndex = 94;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // ctrlDiscountValue
            // 
            this.ctrlDiscountValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlDiscountValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlDiscountValue.EditValue = "";
            this.ctrlDiscountValue.Location = new System.Drawing.Point(259, 562);
            this.ctrlDiscountValue.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlDiscountValue.Name = "ctrlDiscountValue";
            this.ctrlDiscountValue.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlDiscountValue.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlDiscountValue.Properties.Appearance.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ctrlDiscountValue.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlDiscountValue.Properties.Appearance.Options.UseFont = true;
            this.ctrlDiscountValue.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlDiscountValue.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlDiscountValue.Size = new System.Drawing.Size(252, 28);
            this.ctrlDiscountValue.TabIndex = 97;
            // 
            // ctrlTotalValue
            // 
            this.ctrlTotalValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlTotalValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlTotalValue.EditValue = "";
            this.ctrlTotalValue.Location = new System.Drawing.Point(235, 614);
            this.ctrlTotalValue.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlTotalValue.Name = "ctrlTotalValue";
            this.ctrlTotalValue.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlTotalValue.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTotalValue.Properties.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ctrlTotalValue.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlTotalValue.Properties.Appearance.Options.UseFont = true;
            this.ctrlTotalValue.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlTotalValue.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlTotalValue.Size = new System.Drawing.Size(252, 28);
            this.ctrlTotalValue.TabIndex = 98;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(35, 566);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(204, 23);
            this.labelControl2.TabIndex = 99;
            this.labelControl2.Text = "Your discount value is:";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(35, 617);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(170, 23);
            this.labelControl3.TabIndex = 100;
            this.labelControl3.Text = "Your Total value is:";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(35, 665);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(154, 23);
            this.labelControl4.TabIndex = 101;
            this.labelControl4.Text = "Your total cost is:";
            // 
            // ctrlTotalCost
            // 
            this.ctrlTotalCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlTotalCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlTotalCost.EditValue = "";
            this.ctrlTotalCost.Location = new System.Drawing.Point(235, 660);
            this.ctrlTotalCost.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlTotalCost.Name = "ctrlTotalCost";
            this.ctrlTotalCost.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlTotalCost.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.ctrlTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlTotalCost.Properties.Appearance.Options.UseFont = true;
            this.ctrlTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlTotalCost.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlTotalCost.Size = new System.Drawing.Size(252, 28);
            this.ctrlTotalCost.TabIndex = 102;
            // 
            // ctrlQuantity2
            // 
            this.ctrlQuantity2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ctrlQuantity2.Location = new System.Drawing.Point(692, 210);
            this.ctrlQuantity2.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlQuantity2.Name = "ctrlQuantity2";
            this.ctrlQuantity2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlQuantity2.Size = new System.Drawing.Size(113, 24);
            this.ctrlQuantity2.TabIndex = 103;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDelete.Location = new System.Drawing.Point(692, 334);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 34);
            this.btnDelete.TabIndex = 104;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSave.Location = new System.Drawing.Point(692, 411);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 34);
            this.btnSave.TabIndex = 105;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1703, 726);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.ctrlQuantity2);
            this.Controls.Add(this.ctrlTotalCost);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.ctrlTotalValue);
            this.Controls.Add(this.ctrlDiscountValue);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.labelcontrolCustomer);
            this.Controls.Add(this.ctrlCustomerID);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridTransactionLine);
            this.Controls.Add(this.gridViewItems);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransactionLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDiscountValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlQuantity2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewListItems;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colIItemType;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCost;
        private DevExpress.XtraGrid.GridControl gridTransactionLine;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTransactionLine;
        private DevExpress.XtraGrid.Columns.GridColumn colItemID;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colItemPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colValue;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemType;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit ctrlCustomerID;
        private DevExpress.XtraEditors.LabelControl labelcontrolCustomer;
        private DevExpress.XtraEditors.SimpleButton btnAddItem;
        private DevExpress.XtraEditors.TextEdit ctrlDiscountValue;
        private DevExpress.XtraEditors.TextEdit ctrlTotalValue;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit ctrlTotalCost;
        private DevExpress.XtraEditors.SpinEdit ctrlQuantity2;
        private DevExpress.XtraGrid.GridControl gridViewItems;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private DevExpress.XtraGrid.Columns.GridColumn coldIDD;
        private DevExpress.XtraGrid.Columns.GridColumn colTransID;
    }
}

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
            this.gridTransactionLines = new DevExpress.XtraGrid.GridControl();
            this.gridViewTransactionLine = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlCustomerID = new DevExpress.XtraEditors.TextEdit();
            this.labelcontrolCustomer = new DevExpress.XtraEditors.LabelControl();
            this.btnAddItem = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlItemType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlDiscountValue = new DevExpress.XtraEditors.TextEdit();
            this.ctrlTotalValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlTotalCost = new DevExpress.XtraEditors.TextEdit();
            this.ctrlQuantity2 = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransactionLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlItemType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDiscountValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlQuantity2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewItems
            // 
            this.gridViewItems.Location = new System.Drawing.Point(12, 87);
            this.gridViewItems.MainView = this.gridViewListItems;
            this.gridViewItems.Name = "gridViewItems";
            this.gridViewItems.Size = new System.Drawing.Size(487, 340);
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
            this.gridViewListItems.GridControl = this.gridViewItems;
            this.gridViewListItems.Name = "gridViewListItems";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // colIItemType
            // 
            this.colIItemType.FieldName = "ItemType";
            this.colIItemType.Name = "colIItemType";
            this.colIItemType.Visible = true;
            this.colIItemType.VisibleIndex = 3;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 4;
            // 
            // colCost
            // 
            this.colCost.FieldName = "Cost";
            this.colCost.Name = "colCost";
            this.colCost.Visible = true;
            this.colCost.VisibleIndex = 5;
            // 
            // gridTransactionLines
            // 
            this.gridTransactionLines.Location = new System.Drawing.Point(788, 99);
            this.gridTransactionLines.MainView = this.gridViewTransactionLine;
            this.gridTransactionLines.Name = "gridTransactionLines";
            this.gridTransactionLines.Size = new System.Drawing.Size(477, 364);
            this.gridTransactionLines.TabIndex = 21;
            this.gridTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTransactionLine});
            // 
            // gridViewTransactionLine
            // 
            this.gridViewTransactionLine.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionId,
            this.colItemID,
            this.colQuantity,
            this.colItemPrice,
            this.colValue,
            this.gridColumn1,
            this.colItemType});
            this.gridViewTransactionLine.GridControl = this.gridTransactionLines;
            this.gridViewTransactionLine.Name = "gridViewTransactionLine";
            // 
            // colTransactionId
            // 
            this.colTransactionId.FieldName = "TransactionId";
            this.colTransactionId.Name = "colTransactionId";
            this.colTransactionId.Visible = true;
            this.colTransactionId.VisibleIndex = 0;
            // 
            // colItemID
            // 
            this.colItemID.FieldName = "ItemID";
            this.colItemID.Name = "colItemID";
            this.colItemID.Visible = true;
            this.colItemID.VisibleIndex = 1;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            // 
            // colItemPrice
            // 
            this.colItemPrice.FieldName = "ItemPrice";
            this.colItemPrice.Name = "colItemPrice";
            this.colItemPrice.Visible = true;
            this.colItemPrice.VisibleIndex = 3;
            // 
            // colValue
            // 
            this.colValue.FieldName = "Value";
            this.colValue.Name = "colValue";
            this.colValue.Visible = true;
            this.colValue.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Cost";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            // 
            // colItemType
            // 
            this.colItemType.FieldName = "ItemType";
            this.colItemType.Name = "colItemType";
            this.colItemType.Visible = true;
            this.colItemType.VisibleIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl1.AppearancePressed.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(339, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(374, 23);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Transaction Form Management System";
            // 
            // ctrlCustomerID
            // 
            this.ctrlCustomerID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlCustomerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlCustomerID.EditValue = "";
            this.ctrlCustomerID.Enabled = false;
            this.ctrlCustomerID.Location = new System.Drawing.Point(162, 55);
            this.ctrlCustomerID.Name = "ctrlCustomerID";
            this.ctrlCustomerID.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlCustomerID.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlCustomerID.Properties.Appearance.ForeColor = System.Drawing.Color.SkyBlue;
            this.ctrlCustomerID.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlCustomerID.Properties.Appearance.Options.UseFont = true;
            this.ctrlCustomerID.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlCustomerID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlCustomerID.Size = new System.Drawing.Size(337, 26);
            this.ctrlCustomerID.TabIndex = 90;
            // 
            // labelcontrolCustomer
            // 
            this.labelcontrolCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelcontrolCustomer.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelcontrolCustomer.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelcontrolCustomer.Appearance.Options.UseFont = true;
            this.labelcontrolCustomer.Appearance.Options.UseForeColor = true;
            this.labelcontrolCustomer.Location = new System.Drawing.Point(12, 57);
            this.labelcontrolCustomer.Name = "labelcontrolCustomer";
            this.labelcontrolCustomer.Size = new System.Drawing.Size(144, 18);
            this.labelcontrolCustomer.TabIndex = 92;
            this.labelcontrolCustomer.Text = "Your Customer ID is:";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddItem.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddItem.Appearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddItem.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnAddItem.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Appearance.Options.UseBackColor = true;
            this.btnAddItem.Appearance.Options.UseBorderColor = true;
            this.btnAddItem.Appearance.Options.UseFont = true;
            this.btnAddItem.Appearance.Options.UseForeColor = true;
            this.btnAddItem.Location = new System.Drawing.Point(598, 167);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(98, 28);
            this.btnAddItem.TabIndex = 94;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // ctrlItemType
            // 
            this.ctrlItemType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlItemType.Location = new System.Drawing.Point(506, 258);
            this.ctrlItemType.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlItemType.Name = "ctrlItemType";
            this.ctrlItemType.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlItemType.Properties.Appearance.Options.UseFont = true;
            this.ctrlItemType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlItemType.Properties.Items.AddRange(new object[] {
            "Fuel",
            "Products",
            "Services"});
            this.ctrlItemType.Size = new System.Drawing.Size(158, 28);
            this.ctrlItemType.TabIndex = 95;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefresh.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnRefresh.Appearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Appearance.Options.UseBackColor = true;
            this.btnRefresh.Appearance.Options.UseBorderColor = true;
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Appearance.Options.UseForeColor = true;
            this.btnRefresh.Location = new System.Drawing.Point(671, 258);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 28);
            this.btnRefresh.TabIndex = 96;
            this.btnRefresh.Text = "Refresh";
            // 
            // ctrlDiscountValue
            // 
            this.ctrlDiscountValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlDiscountValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlDiscountValue.EditValue = "";
            this.ctrlDiscountValue.Location = new System.Drawing.Point(194, 457);
            this.ctrlDiscountValue.Name = "ctrlDiscountValue";
            this.ctrlDiscountValue.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlDiscountValue.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlDiscountValue.Properties.Appearance.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ctrlDiscountValue.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlDiscountValue.Properties.Appearance.Options.UseFont = true;
            this.ctrlDiscountValue.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlDiscountValue.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlDiscountValue.Size = new System.Drawing.Size(189, 24);
            this.ctrlDiscountValue.TabIndex = 97;
            // 
            // ctrlTotalValue
            // 
            this.ctrlTotalValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlTotalValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlTotalValue.EditValue = "";
            this.ctrlTotalValue.Location = new System.Drawing.Point(176, 499);
            this.ctrlTotalValue.Name = "ctrlTotalValue";
            this.ctrlTotalValue.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlTotalValue.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTotalValue.Properties.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ctrlTotalValue.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlTotalValue.Properties.Appearance.Options.UseFont = true;
            this.ctrlTotalValue.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlTotalValue.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlTotalValue.Size = new System.Drawing.Size(189, 26);
            this.ctrlTotalValue.TabIndex = 98;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(26, 460);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(162, 18);
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
            this.labelControl3.Location = new System.Drawing.Point(26, 501);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(134, 18);
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
            this.labelControl4.Location = new System.Drawing.Point(26, 540);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(121, 18);
            this.labelControl4.TabIndex = 101;
            this.labelControl4.Text = "Your total cost is:";
            // 
            // ctrlTotalCost
            // 
            this.ctrlTotalCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlTotalCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlTotalCost.EditValue = "";
            this.ctrlTotalCost.Location = new System.Drawing.Point(176, 536);
            this.ctrlTotalCost.Name = "ctrlTotalCost";
            this.ctrlTotalCost.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlTotalCost.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.ctrlTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlTotalCost.Properties.Appearance.Options.UseFont = true;
            this.ctrlTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlTotalCost.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlTotalCost.Size = new System.Drawing.Size(189, 26);
            this.ctrlTotalCost.TabIndex = 102;
            // 
            // ctrlQuantity2
            // 
            this.ctrlQuantity2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ctrlQuantity2.Location = new System.Drawing.Point(505, 172);
            this.ctrlQuantity2.Name = "ctrlQuantity2";
            this.ctrlQuantity2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlQuantity2.Size = new System.Drawing.Size(85, 20);
            this.ctrlQuantity2.TabIndex = 103;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 590);
            this.Controls.Add(this.ctrlQuantity2);
            this.Controls.Add(this.ctrlTotalCost);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.ctrlTotalValue);
            this.Controls.Add(this.ctrlDiscountValue);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.ctrlItemType);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.labelcontrolCustomer);
            this.Controls.Add(this.ctrlCustomerID);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridTransactionLines);
            this.Controls.Add(this.gridViewItems);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransactionLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlItemType.Properties)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridTransactionLines;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTransactionLine;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionId;
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
        private DevExpress.XtraEditors.ComboBoxEdit ctrlItemType;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.TextEdit ctrlDiscountValue;
        private DevExpress.XtraEditors.TextEdit ctrlTotalValue;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit ctrlTotalCost;
        private DevExpress.XtraEditors.SpinEdit ctrlQuantity2;
        private DevExpress.XtraGrid.GridControl gridViewItems;
    }
}
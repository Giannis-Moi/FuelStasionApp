
namespace FuelStationApp.WUI {
    partial class ViewTransactionFormLine {
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridTransactionLine = new DevExpress.XtraGrid.GridControl();
            this.gridViewTransactionLine = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemType = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransactionLine)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl1.AppearancePressed.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(211, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(687, 36);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Fuel Station Management System Application";
            // 
            // gridTransactionLine
            // 
            this.gridTransactionLine.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridTransactionLine.Location = new System.Drawing.Point(16, 73);
            this.gridTransactionLine.MainView = this.gridViewTransactionLine;
            this.gridTransactionLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridTransactionLine.Name = "gridTransactionLine";
            this.gridTransactionLine.Size = new System.Drawing.Size(1035, 433);
            this.gridTransactionLine.TabIndex = 20;
            this.gridTransactionLine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.colCost,
            this.colItemType});
            this.gridViewTransactionLine.DetailHeight = 431;
            this.gridViewTransactionLine.GridControl = this.gridTransactionLine;
            this.gridViewTransactionLine.Name = "gridViewTransactionLine";
            // 
            // colTransactionId
            // 
            this.colTransactionId.FieldName = "TransactionId";
            this.colTransactionId.MinWidth = 27;
            this.colTransactionId.Name = "colTransactionId";
            this.colTransactionId.Width = 100;
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
            // colCost
            // 
            this.colCost.FieldName = "Cost";
            this.colCost.MinWidth = 27;
            this.colCost.Name = "colCost";
            this.colCost.Width = 100;
            // 
            // colItemType
            // 
            this.colItemType.FieldName = "ItemType";
            this.colItemType.MinWidth = 27;
            this.colItemType.Name = "colItemType";
            this.colItemType.Width = 100;
            // 
            // ViewTransactionFormLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gridTransactionLine);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewTransactionFormLine";
            this.Text = "ViewTransactionFormLine";
            this.Load += new System.EventHandler(this.ViewTransactionFormLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransactionLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridTransactionLine;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTransactionLine;
        private DevExpress.XtraGrid.Columns.GridColumn colItemID;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colItemPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionId;
        private DevExpress.XtraGrid.Columns.GridColumn colCost;
        private DevExpress.XtraGrid.Columns.GridColumn colItemType;
    }
}
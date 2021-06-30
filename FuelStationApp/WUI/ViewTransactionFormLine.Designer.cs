
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
            this.labelControl1.Location = new System.Drawing.Point(158, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(544, 29);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Fuel Station Management System Application";
            // 
            // gridTransactionLine
            // 
            this.gridTransactionLine.Location = new System.Drawing.Point(12, 59);
            this.gridTransactionLine.MainView = this.gridViewTransactionLine;
            this.gridTransactionLine.Name = "gridTransactionLine";
            this.gridTransactionLine.Size = new System.Drawing.Size(776, 352);
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
            this.gridViewTransactionLine.GridControl = this.gridTransactionLine;
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
            // colCost
            // 
            this.colCost.FieldName = "Cost";
            this.colCost.Name = "colCost";
            this.colCost.Visible = true;
            this.colCost.VisibleIndex = 5;
            // 
            // colItemType
            // 
            this.colItemType.FieldName = "ItemType";
            this.colItemType.Name = "colItemType";
            this.colItemType.Visible = true;
            this.colItemType.VisibleIndex = 6;
            // 
            // ViewTransactionFormLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridTransactionLine);
            this.Controls.Add(this.labelControl1);
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
﻿
namespace FuelStationApp.WUI {
    partial class ViewTransactionForm {
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridTransaction = new DevExpress.XtraGrid.GridControl();
            this.gridViewTransaction = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDiscountValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControlName = new DevExpress.XtraEditors.LabelControl();
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            this.btnViewTransactionLine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).BeginInit();
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
            this.labelControl1.Location = new System.Drawing.Point(175, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(687, 36);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Fuel Station Management System Application";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl2.AppearancePressed.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(395, 58);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(208, 29);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "View Transaction";
            // 
            // gridTransaction
            // 
            this.gridTransaction.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridTransaction.Location = new System.Drawing.Point(16, 94);
            this.gridTransaction.MainView = this.gridViewTransaction;
            this.gridTransaction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridTransaction.Name = "gridTransaction";
            this.gridTransaction.Size = new System.Drawing.Size(767, 433);
            this.gridTransaction.TabIndex = 19;
            this.gridTransaction.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTransaction});
            // 
            // gridViewTransaction
            // 
            this.gridViewTransaction.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDate,
            this.colCustomerID,
            this.colTotalValue,
            this.colTotalCost,
            this.ColDiscountValue});
            this.gridViewTransaction.DetailHeight = 431;
            this.gridViewTransaction.GridControl = this.gridTransaction;
            this.gridViewTransaction.Name = "gridViewTransaction";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 27;
            this.colID.Name = "colID";
            this.colID.Width = 100;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.MinWidth = 27;
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            this.colDate.Width = 100;
            // 
            // colCustomerID
            // 
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.MinWidth = 27;
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.Width = 100;
            // 
            // colTotalValue
            // 
            this.colTotalValue.FieldName = "TotalValue";
            this.colTotalValue.MinWidth = 27;
            this.colTotalValue.Name = "colTotalValue";
            this.colTotalValue.Visible = true;
            this.colTotalValue.VisibleIndex = 2;
            this.colTotalValue.Width = 100;
            // 
            // colTotalCost
            // 
            this.colTotalCost.FieldName = "TotalCost";
            this.colTotalCost.MinWidth = 27;
            this.colTotalCost.Name = "colTotalCost";
            this.colTotalCost.Width = 100;
            // 
            // ColDiscountValue
            // 
            this.ColDiscountValue.FieldName = "DiscountValue";
            this.ColDiscountValue.MinWidth = 27;
            this.ColDiscountValue.Name = "ColDiscountValue";
            this.ColDiscountValue.Visible = true;
            this.ColDiscountValue.VisibleIndex = 1;
            this.ColDiscountValue.Width = 100;
            // 
            // labelControlName
            // 
            this.labelControlName.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControlName.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControlName.Appearance.Options.UseFont = true;
            this.labelControlName.Appearance.Options.UseForeColor = true;
            this.labelControlName.Location = new System.Drawing.Point(807, 100);
            this.labelControlName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControlName.Name = "labelControlName";
            this.labelControlName.Size = new System.Drawing.Size(70, 19);
            this.labelControlName.TabIndex = 20;
            this.labelControlName.Text = "Card ID:";
            // 
            // ctrlName
            // 
            this.ctrlName.Location = new System.Drawing.Point(897, 98);
            this.ctrlName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Size = new System.Drawing.Size(288, 22);
            this.ctrlName.TabIndex = 21;
            // 
            // btnViewTransactionLine
            // 
            this.btnViewTransactionLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnViewTransactionLine.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewTransactionLine.Location = new System.Drawing.Point(937, 158);
            this.btnViewTransactionLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewTransactionLine.Name = "btnViewTransactionLine";
            this.btnViewTransactionLine.Size = new System.Drawing.Size(197, 52);
            this.btnViewTransactionLine.TabIndex = 22;
            this.btnViewTransactionLine.Text = "View Transaction Line Record";
            this.btnViewTransactionLine.UseVisualStyleBackColor = true;
            this.btnViewTransactionLine.Click += new System.EventHandler(this.btnViewTransactionLine_Click);
            // 
            // ViewTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 554);
            this.Controls.Add(this.btnViewTransactionLine);
            this.Controls.Add(this.ctrlName);
            this.Controls.Add(this.labelControlName);
            this.Controls.Add(this.gridTransaction);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewTransactionForm";
            this.Text = "ViewTransactionForm";
            this.Load += new System.EventHandler(this.ViewTransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridTransaction;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTransaction;
        private DevExpress.XtraEditors.LabelControl labelControlName;
        private DevExpress.XtraEditors.TextEdit ctrlName;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCost;
        private System.Windows.Forms.Button btnViewTransactionLine;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn ColDiscountValue;
    }
}
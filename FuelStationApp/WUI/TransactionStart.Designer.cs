
namespace FuelStationApp.WUI {
    partial class TransactionStart {
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
            this.ctrlCardNumber = new System.Windows.Forms.ComboBox();
            this.gridCustomers = new DevExpress.XtraGrid.GridControl();
            this.gridViewCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControlCardNumber = new DevExpress.XtraEditors.LabelControl();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.btnNewTransaction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlCardNumber
            // 
            this.ctrlCardNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlCardNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlCardNumber.FormattingEnabled = true;
            this.ctrlCardNumber.Location = new System.Drawing.Point(739, 101);
            this.ctrlCardNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlCardNumber.Name = "ctrlCardNumber";
            this.ctrlCardNumber.Size = new System.Drawing.Size(284, 31);
            this.ctrlCardNumber.TabIndex = 90;
            // 
            // gridCustomers
            // 
            this.gridCustomers.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridCustomers.Location = new System.Drawing.Point(16, 42);
            this.gridCustomers.MainView = this.gridViewCustomer;
            this.gridCustomers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.Size = new System.Drawing.Size(660, 383);
            this.gridCustomers.TabIndex = 91;
            this.gridCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCustomer});
            // 
            // gridViewCustomer
            // 
            this.gridViewCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colSurname,
            this.colCardNumber});
            this.gridViewCustomer.DetailHeight = 431;
            this.gridViewCustomer.GridControl = this.gridCustomers;
            this.gridViewCustomer.Name = "gridViewCustomer";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 27;
            this.colID.Name = "colID";
            this.colID.Width = 100;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 27;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 100;
            // 
            // colSurname
            // 
            this.colSurname.FieldName = "Surname";
            this.colSurname.MinWidth = 27;
            this.colSurname.Name = "colSurname";
            this.colSurname.Visible = true;
            this.colSurname.VisibleIndex = 1;
            this.colSurname.Width = 100;
            // 
            // colCardNumber
            // 
            this.colCardNumber.FieldName = "CardNumber";
            this.colCardNumber.MinWidth = 27;
            this.colCardNumber.Name = "colCardNumber";
            this.colCardNumber.Visible = true;
            this.colCardNumber.VisibleIndex = 2;
            this.colCardNumber.Width = 100;
            // 
            // labelControlCardNumber
            // 
            this.labelControlCardNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControlCardNumber.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControlCardNumber.Appearance.Options.UseFont = true;
            this.labelControlCardNumber.Appearance.Options.UseForeColor = true;
            this.labelControlCardNumber.Location = new System.Drawing.Point(805, 57);
            this.labelControlCardNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControlCardNumber.Name = "labelControlCardNumber";
            this.labelControlCardNumber.Size = new System.Drawing.Size(115, 19);
            this.labelControlCardNumber.TabIndex = 92;
            this.labelControlCardNumber.Text = "Card Number:";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnSearchCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchCustomer.Location = new System.Drawing.Point(785, 160);
            this.btnSearchCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(197, 52);
            this.btnSearchCustomer.TabIndex = 93;
            this.btnSearchCustomer.Text = "Search Customer";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnNewTransaction.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNewTransaction.Location = new System.Drawing.Point(785, 260);
            this.btnNewTransaction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(197, 52);
            this.btnNewTransaction.TabIndex = 94;
            this.btnNewTransaction.Text = "New Transaction";
            this.btnNewTransaction.UseVisualStyleBackColor = true;
            this.btnNewTransaction.Click += new System.EventHandler(this.btnNewTransaction_Click);
            // 
            // TransactionStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnNewTransaction);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.labelControlCardNumber);
            this.Controls.Add(this.gridCustomers);
            this.Controls.Add(this.ctrlCardNumber);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TransactionStart";
            this.Text = "TransactionStart";
            this.Load += new System.EventHandler(this.TransactionStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ctrlCardNumber;
        private DevExpress.XtraGrid.GridControl gridCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colCardNumber;
        private DevExpress.XtraEditors.LabelControl labelControlCardNumber;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnNewTransaction;
    }
}
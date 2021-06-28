
namespace FuelStationApp.WUI {
    partial class CustomerForm {
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
            this.gridCustomers = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControlName = new DevExpress.XtraEditors.LabelControl();
            this.labelControlSurname = new DevExpress.XtraEditors.LabelControl();
            this.labelControlCardnumber = new DevExpress.XtraEditors.LabelControl();
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            this.ctrlSurname = new DevExpress.XtraEditors.TextEdit();
            this.ctrlCardNumber = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCardNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl1.AppearancePressed.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(231, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(309, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Customers Management System";
            // 
            // gridCustomers
            // 
            this.gridCustomers.Location = new System.Drawing.Point(12, 55);
            this.gridCustomers.MainView = this.gridView1;
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.Size = new System.Drawing.Size(628, 373);
            this.gridCustomers.TabIndex = 1;
            this.gridCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridCustomers.Click += new System.EventHandler(this.gridCustomers_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colSurname,
            this.colCardNumber});
            this.gridView1.GridControl = this.gridCustomers;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colSurname
            // 
            this.colSurname.FieldName = "Surname";
            this.colSurname.Name = "colSurname";
            this.colSurname.Visible = true;
            this.colSurname.VisibleIndex = 2;
            // 
            // colCardNumber
            // 
            this.colCardNumber.FieldName = "CardNumber";
            this.colCardNumber.Name = "colCardNumber";
            this.colCardNumber.Visible = true;
            this.colCardNumber.VisibleIndex = 3;
            // 
            // labelControlName
            // 
            this.labelControlName.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControlName.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControlName.Appearance.Options.UseFont = true;
            this.labelControlName.Appearance.Options.UseForeColor = true;
            this.labelControlName.Location = new System.Drawing.Point(698, 67);
            this.labelControlName.Name = "labelControlName";
            this.labelControlName.Size = new System.Drawing.Size(41, 16);
            this.labelControlName.TabIndex = 2;
            this.labelControlName.Text = "Name:";
            // 
            // labelControlSurname
            // 
            this.labelControlSurname.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControlSurname.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControlSurname.Appearance.Options.UseFont = true;
            this.labelControlSurname.Appearance.Options.UseForeColor = true;
            this.labelControlSurname.Location = new System.Drawing.Point(698, 128);
            this.labelControlSurname.Name = "labelControlSurname";
            this.labelControlSurname.Size = new System.Drawing.Size(62, 16);
            this.labelControlSurname.TabIndex = 3;
            this.labelControlSurname.Text = "Surname:";
            // 
            // labelControlCardnumber
            // 
            this.labelControlCardnumber.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControlCardnumber.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControlCardnumber.Appearance.Options.UseFont = true;
            this.labelControlCardnumber.Appearance.Options.UseForeColor = true;
            this.labelControlCardnumber.Location = new System.Drawing.Point(697, 184);
            this.labelControlCardnumber.Name = "labelControlCardnumber";
            this.labelControlCardnumber.Size = new System.Drawing.Size(89, 16);
            this.labelControlCardnumber.TabIndex = 4;
            this.labelControlCardnumber.Text = "Card Number:";
            // 
            // ctrlName
            // 
            this.ctrlName.Location = new System.Drawing.Point(777, 66);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Size = new System.Drawing.Size(152, 20);
            this.ctrlName.TabIndex = 5;
            // 
            // ctrlSurname
            // 
            this.ctrlSurname.Location = new System.Drawing.Point(777, 127);
            this.ctrlSurname.Name = "ctrlSurname";
            this.ctrlSurname.Size = new System.Drawing.Size(152, 20);
            this.ctrlSurname.TabIndex = 6;
            // 
            // ctrlCardNumber
            // 
            this.ctrlCardNumber.Location = new System.Drawing.Point(792, 183);
            this.ctrlCardNumber.Name = "ctrlCardNumber";
            this.ctrlCardNumber.Size = new System.Drawing.Size(137, 20);
            this.ctrlCardNumber.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(691, 266);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 42);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Insert Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(802, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(894, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 576);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ctrlCardNumber);
            this.Controls.Add(this.ctrlSurname);
            this.Controls.Add(this.ctrlName);
            this.Controls.Add(this.labelControlCardnumber);
            this.Controls.Add(this.labelControlSurname);
            this.Controls.Add(this.labelControlName);
            this.Controls.Add(this.gridCustomers);
            this.Controls.Add(this.labelControl1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCardNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraEditors.LabelControl labelControlName;
        private DevExpress.XtraEditors.LabelControl labelControlSurname;
        private DevExpress.XtraEditors.LabelControl labelControlCardnumber;
        private DevExpress.XtraEditors.TextEdit ctrlName;
        private DevExpress.XtraEditors.TextEdit ctrlSurname;
        private DevExpress.XtraEditors.TextEdit ctrlCardNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private DevExpress.XtraGrid.Columns.GridColumn colCardNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
    }
}
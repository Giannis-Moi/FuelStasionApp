
namespace FuelStationApp.WUI {
    partial class EmployeeForm {
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
            this.labelControlName = new DevExpress.XtraEditors.LabelControl();
            this.labelControlSurname = new DevExpress.XtraEditors.LabelControl();
            this.labelControlDateEnd = new DevExpress.XtraEditors.LabelControl();
            this.labelControlDateStart = new DevExpress.XtraEditors.LabelControl();
            this.labelControlSalary = new DevExpress.XtraEditors.LabelControl();
            this.gridCustomers = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            this.ctrlSurname = new DevExpress.XtraEditors.TextEdit();
            this.ctrlSalary = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSalary.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControlName
            // 
            this.labelControlName.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControlName.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControlName.Appearance.Options.UseFont = true;
            this.labelControlName.Appearance.Options.UseForeColor = true;
            this.labelControlName.Location = new System.Drawing.Point(723, 78);
            this.labelControlName.Name = "labelControlName";
            this.labelControlName.Size = new System.Drawing.Size(41, 16);
            this.labelControlName.TabIndex = 3;
            this.labelControlName.Text = "Name:";
            // 
            // labelControlSurname
            // 
            this.labelControlSurname.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControlSurname.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControlSurname.Appearance.Options.UseFont = true;
            this.labelControlSurname.Appearance.Options.UseForeColor = true;
            this.labelControlSurname.Location = new System.Drawing.Point(723, 136);
            this.labelControlSurname.Name = "labelControlSurname";
            this.labelControlSurname.Size = new System.Drawing.Size(63, 16);
            this.labelControlSurname.TabIndex = 4;
            this.labelControlSurname.Text = "Surname:";
            // 
            // labelControlDateEnd
            // 
            this.labelControlDateEnd.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControlDateEnd.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControlDateEnd.Appearance.Options.UseFont = true;
            this.labelControlDateEnd.Appearance.Options.UseForeColor = true;
            this.labelControlDateEnd.Location = new System.Drawing.Point(723, 236);
            this.labelControlDateEnd.Name = "labelControlDateEnd";
            this.labelControlDateEnd.Size = new System.Drawing.Size(64, 16);
            this.labelControlDateEnd.TabIndex = 5;
            this.labelControlDateEnd.Text = "Date End:";
            // 
            // labelControlDateStart
            // 
            this.labelControlDateStart.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControlDateStart.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControlDateStart.Appearance.Options.UseFont = true;
            this.labelControlDateStart.Appearance.Options.UseForeColor = true;
            this.labelControlDateStart.Location = new System.Drawing.Point(723, 185);
            this.labelControlDateStart.Name = "labelControlDateStart";
            this.labelControlDateStart.Size = new System.Drawing.Size(75, 16);
            this.labelControlDateStart.TabIndex = 6;
            this.labelControlDateStart.Text = "Date Start:";
            // 
            // labelControlSalary
            // 
            this.labelControlSalary.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControlSalary.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControlSalary.Appearance.Options.UseFont = true;
            this.labelControlSalary.Appearance.Options.UseForeColor = true;
            this.labelControlSalary.Location = new System.Drawing.Point(723, 285);
            this.labelControlSalary.Name = "labelControlSalary";
            this.labelControlSalary.Size = new System.Drawing.Size(96, 16);
            this.labelControlSalary.TabIndex = 7;
            this.labelControlSalary.Text = "Salary/Month:";
            // 
            // gridCustomers
            // 
            this.gridCustomers.Location = new System.Drawing.Point(12, 78);
            this.gridCustomers.MainView = this.gridView1;
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.Size = new System.Drawing.Size(576, 357);
            this.gridCustomers.TabIndex = 8;
            this.gridCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl1.AppearancePressed.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(305, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(310, 23);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Employees Management System";
            // 
            // ctrlName
            // 
            this.ctrlName.Location = new System.Drawing.Point(825, 74);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Size = new System.Drawing.Size(152, 20);
            this.ctrlName.TabIndex = 10;
            // 
            // ctrlSurname
            // 
            this.ctrlSurname.Location = new System.Drawing.Point(825, 135);
            this.ctrlSurname.Name = "ctrlSurname";
            this.ctrlSurname.Size = new System.Drawing.Size(152, 20);
            this.ctrlSurname.TabIndex = 11;
            // 
            // ctrlSalary
            // 
            this.ctrlSalary.Location = new System.Drawing.Point(825, 284);
            this.ctrlSalary.Name = "ctrlSalary";
            this.ctrlSalary.Size = new System.Drawing.Size(152, 20);
            this.ctrlSalary.TabIndex = 12;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 542);
            this.Controls.Add(this.ctrlSalary);
            this.Controls.Add(this.ctrlSurname);
            this.Controls.Add(this.ctrlName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridCustomers);
            this.Controls.Add(this.labelControlSalary);
            this.Controls.Add(this.labelControlDateStart);
            this.Controls.Add(this.labelControlDateEnd);
            this.Controls.Add(this.labelControlSurname);
            this.Controls.Add(this.labelControlName);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSalary.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControlName;
        private DevExpress.XtraEditors.LabelControl labelControlSurname;
        private DevExpress.XtraEditors.LabelControl labelControlDateEnd;
        private DevExpress.XtraEditors.LabelControl labelControlDateStart;
        private DevExpress.XtraEditors.LabelControl labelControlSalary;
        private DevExpress.XtraGrid.GridControl gridCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colCardNumber;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit ctrlName;
        private DevExpress.XtraEditors.TextEdit ctrlSurname;
        private DevExpress.XtraEditors.TextEdit ctrlSalary;
    }
}
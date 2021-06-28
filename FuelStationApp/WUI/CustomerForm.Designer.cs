
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControlName = new DevExpress.XtraEditors.LabelControl();
            this.labelControlSurname = new DevExpress.XtraEditors.LabelControl();
            this.labelControlSalary = new DevExpress.XtraEditors.LabelControl();
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            this.ctrSurname = new DevExpress.XtraEditors.TextEdit();
            this.ctrlSalary = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSalary.Properties)).BeginInit();
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
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(51, 56);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(628, 373);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colSurname,
            this.colDateStart,
            this.colDateEnd,
            this.colSalary});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // labelControlName
            // 
            this.labelControlName.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControlName.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControlName.Appearance.Options.UseFont = true;
            this.labelControlName.Appearance.Options.UseForeColor = true;
            this.labelControlName.Location = new System.Drawing.Point(719, 67);
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
            this.labelControlSurname.Location = new System.Drawing.Point(719, 128);
            this.labelControlSurname.Name = "labelControlSurname";
            this.labelControlSurname.Size = new System.Drawing.Size(62, 16);
            this.labelControlSurname.TabIndex = 3;
            this.labelControlSurname.Text = "Surname:";
            // 
            // labelControlSalary
            // 
            this.labelControlSalary.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControlSalary.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControlSalary.Appearance.Options.UseFont = true;
            this.labelControlSalary.Appearance.Options.UseForeColor = true;
            this.labelControlSalary.Location = new System.Drawing.Point(719, 184);
            this.labelControlSalary.Name = "labelControlSalary";
            this.labelControlSalary.Size = new System.Drawing.Size(47, 16);
            this.labelControlSalary.TabIndex = 4;
            this.labelControlSalary.Text = "Salary:";
            // 
            // ctrlName
            // 
            this.ctrlName.Location = new System.Drawing.Point(792, 66);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Size = new System.Drawing.Size(137, 20);
            this.ctrlName.TabIndex = 5;
            // 
            // ctrSurname
            // 
            this.ctrSurname.Location = new System.Drawing.Point(792, 127);
            this.ctrSurname.Name = "ctrSurname";
            this.ctrSurname.Size = new System.Drawing.Size(137, 20);
            this.ctrSurname.TabIndex = 6;
            // 
            // ctrlSalary
            // 
            this.ctrlSalary.Location = new System.Drawing.Point(792, 183);
            this.ctrlSalary.Name = "ctrlSalary";
            this.ctrlSalary.Size = new System.Drawing.Size(137, 20);
            this.ctrlSalary.TabIndex = 7;
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
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
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
            // colDateStart
            // 
            this.colDateStart.FieldName = "DateStart";
            this.colDateStart.Name = "colDateStart";
            this.colDateStart.Visible = true;
            this.colDateStart.VisibleIndex = 3;
            // 
            // colDateEnd
            // 
            this.colDateEnd.Caption = "DateEnd";
            this.colDateEnd.FieldName = "DateEnd";
            this.colDateEnd.Name = "colDateEnd";
            this.colDateEnd.Visible = true;
            this.colDateEnd.VisibleIndex = 4;
            // 
            // colSalary
            // 
            this.colSalary.Caption = "Salary";
            this.colSalary.FieldName = "Salary";
            this.colSalary.Name = "colSalary";
            this.colSalary.Visible = true;
            this.colSalary.VisibleIndex = 5;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 576);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ctrlSalary);
            this.Controls.Add(this.ctrSurname);
            this.Controls.Add(this.ctrlName);
            this.Controls.Add(this.labelControlSalary);
            this.Controls.Add(this.labelControlSurname);
            this.Controls.Add(this.labelControlName);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSalary.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colDateStart;
        private DevExpress.XtraGrid.Columns.GridColumn colDateEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colSalary;
        private DevExpress.XtraEditors.LabelControl labelControlName;
        private DevExpress.XtraEditors.LabelControl labelControlSurname;
        private DevExpress.XtraEditors.LabelControl labelControlSalary;
        private DevExpress.XtraEditors.TextEdit ctrlName;
        private DevExpress.XtraEditors.TextEdit ctrSurname;
        private DevExpress.XtraEditors.TextEdit ctrlSalary;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
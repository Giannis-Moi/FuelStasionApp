
namespace FuelStationApp.WUI {
    partial class ItemForm {
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlCode = new DevExpress.XtraEditors.TextEdit();
            this.ctrlDescription = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ctrlPrice = new DevExpress.XtraEditors.SpinEdit();
            this.ctrlCost = new DevExpress.XtraEditors.SpinEdit();
            this.btnInsertValues = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gridItems = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIItemType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnok = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.ctrlItemType = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlItemType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(636, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Code:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(636, 88);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Description:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(637, 118);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Type:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(636, 147);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Price:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(636, 183);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 16);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Cost:";
            // 
            // ctrlCode
            // 
            this.ctrlCode.Location = new System.Drawing.Point(720, 46);
            this.ctrlCode.Name = "ctrlCode";
            this.ctrlCode.Size = new System.Drawing.Size(219, 20);
            this.ctrlCode.TabIndex = 6;
            // 
            // ctrlDescription
            // 
            this.ctrlDescription.Location = new System.Drawing.Point(720, 84);
            this.ctrlDescription.Name = "ctrlDescription";
            this.ctrlDescription.Size = new System.Drawing.Size(219, 20);
            this.ctrlDescription.TabIndex = 7;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.AllowDrop = true;
            this.comboBoxEdit1.Location = new System.Drawing.Point(720, 117);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.DropDownRows = 3;
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Fuel",
            "Product",
            "Service"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(219, 20);
            this.comboBoxEdit1.TabIndex = 13;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // ctrlPrice
            // 
            this.ctrlPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ctrlPrice.Location = new System.Drawing.Point(720, 146);
            this.ctrlPrice.Name = "ctrlPrice";
            this.ctrlPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlPrice.Size = new System.Drawing.Size(219, 20);
            this.ctrlPrice.TabIndex = 14;
            // 
            // ctrlCost
            // 
            this.ctrlCost.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ctrlCost.Location = new System.Drawing.Point(720, 182);
            this.ctrlCost.Name = "ctrlCost";
            this.ctrlCost.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlCost.Size = new System.Drawing.Size(219, 20);
            this.ctrlCost.TabIndex = 15;
            // 
            // btnInsertValues
            // 
            this.btnInsertValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnInsertValues.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsertValues.Location = new System.Drawing.Point(679, 232);
            this.btnInsertValues.Name = "btnInsertValues";
            this.btnInsertValues.Size = new System.Drawing.Size(79, 42);
            this.btnInsertValues.TabIndex = 16;
            this.btnInsertValues.Text = "Insert Record";
            this.btnInsertValues.UseVisualStyleBackColor = true;
            this.btnInsertValues.Click += new System.EventHandler(this.btnInsertValues_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.Location = new System.Drawing.Point(844, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 42);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gridItems
            // 
            this.gridItems.Location = new System.Drawing.Point(12, 33);
            this.gridItems.MainView = this.gridView1;
            this.gridItems.Name = "gridItems";
            this.gridItems.Size = new System.Drawing.Size(575, 352);
            this.gridItems.TabIndex = 18;
            this.gridItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCode,
            this.colDescription,
            this.colIItemType,
            this.colPrice,
            this.colCost});
            this.gridView1.GridControl = this.gridItems;
            this.gridView1.Name = "gridView1";
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
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnok.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnok.Location = new System.Drawing.Point(720, 380);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(95, 42);
            this.btnok.TabIndex = 19;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndelete.Location = new System.Drawing.Point(764, 232);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(83, 42);
            this.btndelete.TabIndex = 20;
            this.btndelete.Text = "Delete Record";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnupdate.Location = new System.Drawing.Point(853, 232);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(86, 42);
            this.btnupdate.TabIndex = 21;
            this.btnupdate.Text = "Update Record";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnView.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnView.Location = new System.Drawing.Point(593, 232);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(80, 42);
            this.btnView.TabIndex = 22;
            this.btnView.Text = "View Records";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // ctrlItemType
            // 
            this.ctrlItemType.Location = new System.Drawing.Point(12, 418);
            this.ctrlItemType.Name = "ctrlItemType";
            this.ctrlItemType.Size = new System.Drawing.Size(219, 20);
            this.ctrlItemType.TabIndex = 23;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.ctrlItemType);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.gridItems);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsertValues);
            this.Controls.Add(this.ctrlCost);
            this.Controls.Add(this.ctrlPrice);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.ctrlDescription);
            this.Controls.Add(this.ctrlCode);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlItemType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit ctrlCode;
        private DevExpress.XtraEditors.TextEdit ctrlDescription;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.SpinEdit ctrlPrice;
        private DevExpress.XtraEditors.SpinEdit ctrlCost;
        private System.Windows.Forms.Button btnInsertValues;
        private System.Windows.Forms.Button btnCancel;
        private DevExpress.XtraGrid.GridControl gridItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colIItemType;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCost;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnView;
        private DevExpress.XtraEditors.TextEdit ctrlItemType;
    }
}
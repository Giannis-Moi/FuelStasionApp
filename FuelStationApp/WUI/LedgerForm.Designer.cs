
namespace FuelStationApp.WUI {
    partial class LedgerForm {
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
            this.ctrlDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.ctrlDateΤο = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlIncome = new DevExpress.XtraEditors.TextEdit();
            this.ctrlExpenses = new DevExpress.XtraEditors.TextEdit();
            this.ctrlTotal = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelProfit = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateΤο.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateΤο.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlIncome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlExpenses.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlDateFrom
            // 
            this.ctrlDateFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlDateFrom.EditValue = null;
            this.ctrlDateFrom.Location = new System.Drawing.Point(165, 114);
            this.ctrlDateFrom.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlDateFrom.Name = "ctrlDateFrom";
            this.ctrlDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlDateFrom.Size = new System.Drawing.Size(180, 22);
            this.ctrlDateFrom.TabIndex = 45;
            // 
            // ctrlDateΤο
            // 
            this.ctrlDateΤο.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlDateΤο.EditValue = null;
            this.ctrlDateΤο.Location = new System.Drawing.Point(165, 182);
            this.ctrlDateΤο.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlDateΤο.Name = "ctrlDateΤο";
            this.ctrlDateΤο.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlDateΤο.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlDateΤο.Size = new System.Drawing.Size(180, 22);
            this.ctrlDateΤο.TabIndex = 46;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(16, 118);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(104, 23);
            this.labelControl4.TabIndex = 47;
            this.labelControl4.Text = "Date Start:";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 186);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 23);
            this.labelControl1.TabIndex = 48;
            this.labelControl1.Text = "Date End:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl2.AppearancePressed.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(205, 15);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(687, 36);
            this.labelControl2.TabIndex = 49;
            this.labelControl2.Text = "Fuel Station Management System Application";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(16, 305);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(80, 23);
            this.labelControl3.TabIndex = 50;
            this.labelControl3.Text = "Income:";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(16, 391);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(94, 23);
            this.labelControl5.TabIndex = 51;
            this.labelControl5.Text = "Expenses:";
            // 
            // ctrlIncome
            // 
            this.ctrlIncome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlIncome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlIncome.EditValue = "";
            this.ctrlIncome.Enabled = false;
            this.ctrlIncome.Location = new System.Drawing.Point(165, 299);
            this.ctrlIncome.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlIncome.Name = "ctrlIncome";
            this.ctrlIncome.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlIncome.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlIncome.Properties.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ctrlIncome.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlIncome.Properties.Appearance.Options.UseFont = true;
            this.ctrlIncome.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlIncome.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlIncome.Size = new System.Drawing.Size(449, 28);
            this.ctrlIncome.TabIndex = 93;
            // 
            // ctrlExpenses
            // 
            this.ctrlExpenses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlExpenses.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlExpenses.EditValue = "";
            this.ctrlExpenses.Enabled = false;
            this.ctrlExpenses.Location = new System.Drawing.Point(141, 385);
            this.ctrlExpenses.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlExpenses.Name = "ctrlExpenses";
            this.ctrlExpenses.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlExpenses.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlExpenses.Properties.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ctrlExpenses.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlExpenses.Properties.Appearance.Options.UseFont = true;
            this.ctrlExpenses.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlExpenses.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlExpenses.Size = new System.Drawing.Size(449, 28);
            this.ctrlExpenses.TabIndex = 94;
            // 
            // ctrlTotal
            // 
            this.ctrlTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlTotal.EditValue = "";
            this.ctrlTotal.Enabled = false;
            this.ctrlTotal.Location = new System.Drawing.Point(81, 484);
            this.ctrlTotal.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlTotal.Name = "ctrlTotal";
            this.ctrlTotal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlTotal.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTotal.Properties.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ctrlTotal.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlTotal.Properties.Appearance.Options.UseFont = true;
            this.ctrlTotal.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlTotal.Size = new System.Drawing.Size(449, 28);
            this.ctrlTotal.TabIndex = 95;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.Appearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseBorderColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.Location = new System.Drawing.Point(393, 251);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(285, 41);
            this.btnAdd.TabIndex = 97;
            this.btnAdd.Text = "Calculate the Ledger";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelProfit
            // 
            this.labelProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProfit.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelProfit.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelProfit.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelProfit.Appearance.Options.UseBackColor = true;
            this.labelProfit.Appearance.Options.UseFont = true;
            this.labelProfit.Appearance.Options.UseForeColor = true;
            this.labelProfit.Location = new System.Drawing.Point(393, 420);
            this.labelProfit.Name = "labelProfit";
            this.labelProfit.Size = new System.Drawing.Size(7, 29);
            this.labelProfit.TabIndex = 99;
            this.labelProfit.Text = " ";
            // 
            // LedgerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.labelProfit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ctrlTotal);
            this.Controls.Add(this.ctrlExpenses);
            this.Controls.Add(this.ctrlIncome);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.ctrlDateΤο);
            this.Controls.Add(this.ctrlDateFrom);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LedgerForm";
            this.Text = "LedgerForm";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateΤο.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateΤο.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlIncome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlExpenses.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit ctrlDateFrom;
        private DevExpress.XtraEditors.DateEdit ctrlDateΤο;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit ctrlIncome;
        private DevExpress.XtraEditors.TextEdit ctrlExpenses;
        private DevExpress.XtraEditors.TextEdit ctrlTotal;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.LabelControl labelProfit;
    }
}
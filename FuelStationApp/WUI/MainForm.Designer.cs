
namespace FuelStationApp {
    partial class MainForm {
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.getCustomersData = new DevExpress.XtraBars.BarButtonItem();
            this.ConnectWithDB = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.viewCustomersData = new DevExpress.XtraBars.BarButtonItem();
            this.getEmployeesData = new DevExpress.XtraBars.BarButtonItem();
            this.viewEmloyeesData = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.addCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.txtLog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 156);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1105, 350);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.getCustomersData,
            this.ConnectWithDB,
            this.barButtonItem4,
            this.barButtonItem5,
            this.viewCustomersData,
            this.getEmployeesData,
            this.viewEmloyeesData,
            this.barButtonItem2,
            this.addCustomer});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage3,
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(1117, 150);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Add Customer";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // getCustomersData
            // 
            this.getCustomersData.Caption = "Get Customers Data";
            this.getCustomersData.Id = 2;
            this.getCustomersData.Name = "getCustomersData";
            this.getCustomersData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.getCustomersData_ItemClick);
            // 
            // ConnectWithDB
            // 
            this.ConnectWithDB.Caption = "Connect with SQL Server";
            this.ConnectWithDB.Id = 3;
            this.ConnectWithDB.Name = "ConnectWithDB";
            this.ConnectWithDB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ConnectWithDB_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Save data to Database";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Load Data from DB";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // viewCustomersData
            // 
            this.viewCustomersData.Caption = "View Customers Data";
            this.viewCustomersData.Id = 6;
            this.viewCustomersData.Name = "viewCustomersData";
            this.viewCustomersData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.viewCustomersData_ItemClick);
            // 
            // getEmployeesData
            // 
            this.getEmployeesData.Caption = "Get Employees Data";
            this.getEmployeesData.Id = 7;
            this.getEmployeesData.Name = "getEmployeesData";
            this.getEmployeesData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.getEmployeesData_ItemClick);
            // 
            // viewEmloyeesData
            // 
            this.viewEmloyeesData.Caption = "View Employees Data";
            this.viewEmloyeesData.Id = 8;
            this.viewEmloyeesData.Name = "viewEmloyeesData";
            this.viewEmloyeesData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.viewEmloyeesData_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Clear Data";
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // addCustomer
            // 
            this.addCustomer.Caption = "Add customer";
            this.addCustomer.Id = 10;
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addCustomer_ItemClick);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "FuelStationApp";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.ConnectWithDB);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Customers";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.getCustomersData);
            this.ribbonPageGroup1.ItemLinks.Add(this.viewCustomersData);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.addCustomer, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Employees";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.getEmployeesData);
            this.ribbonPageGroup2.ItemLinks.Add(this.viewEmloyeesData);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "Server=DESKTOP-IAKOVOS;Database=FuelStation;Trusted_Connection=True;";
            this.textEdit1.Location = new System.Drawing.Point(12, 528);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(1093, 20);
            this.textEdit1.TabIndex = 14;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(12, 566);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(1093, 78);
            this.txtLog.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 685);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem getCustomersData;
        private DevExpress.XtraBars.BarButtonItem ConnectWithDB;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.TextBox txtLog;
        private DevExpress.XtraBars.BarButtonItem viewCustomersData;
        private DevExpress.XtraBars.BarButtonItem getEmployeesData;
        private DevExpress.XtraBars.BarButtonItem viewEmloyeesData;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem addCustomer;
    }
}


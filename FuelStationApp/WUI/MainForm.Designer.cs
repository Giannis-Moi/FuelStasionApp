﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.btnInsertItem = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnViewTransaction = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.addEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(40, 37, 40, 37);
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
            this.addCustomer,
            this.btnInsertItem,
            this.barSubItem1,
            this.btnViewTransaction,
            this.barButtonItem3,
            this.addEmployee,
            this.barButtonItem6});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 440;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage3,
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage4,
            this.ribbonPage5,
            this.ribbonPage6});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1489, 199);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Add Customer";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // getCustomersData
            // 
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
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // addCustomer
            // 
            this.addCustomer.Caption = "Customers Management System";
            this.addCustomer.Id = 10;
            this.addCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addCustomer.ImageOptions.Image")));
            this.addCustomer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("addCustomer.ImageOptions.LargeImage")));
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addCustomer_ItemClick);
            // 
            // btnInsertItem
            // 
            this.btnInsertItem.Caption = " Items management system";
            this.btnInsertItem.Id = 11;
            this.btnInsertItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertItem.ImageOptions.Image")));
            this.btnInsertItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInsertItem.ImageOptions.LargeImage")));
            this.btnInsertItem.Name = "btnInsertItem";
            this.btnInsertItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInsertItem_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 12;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnViewTransaction
            // 
            this.btnViewTransaction.Caption = "VIew transaction";
            this.btnViewTransaction.Id = 13;
            this.btnViewTransaction.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewTransaction.ImageOptions.Image")));
            this.btnViewTransaction.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnViewTransaction.ImageOptions.LargeImage")));
            this.btnViewTransaction.Name = "btnViewTransaction";
            this.btnViewTransaction.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewTransaction_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "New Transaction";
            this.barButtonItem3.Id = 14;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // addEmployee
            // 
            this.addEmployee.Caption = "Employees Management System";
            this.addEmployee.Id = 15;
            this.addEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addEmployee.ImageOptions.Image")));
            this.addEmployee.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("addEmployee.ImageOptions.LargeImage")));
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addEmployee_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "View Ledger";
            this.barButtonItem6.Id = 16;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.ImageOptions.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "FuelStationApp";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.ConnectWithDB);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
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
            this.ribbonPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.ImageOptions.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Employees";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.addEmployee);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage4.ImageOptions.Image")));
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Items";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnInsertItem);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup7});
            this.ribbonPage5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage5.ImageOptions.Image")));
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Transactions";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnViewTransaction);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage6.ImageOptions.Image")));
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "Ledger";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "Server=DESKTOP-B2H5QAB\\SQLEXPRESS;Database=FuelStation;Trusted_Connection=True;";
            this.textEdit1.Location = new System.Drawing.Point(0, 207);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(1457, 22);
            this.textEdit1.TabIndex = 14;
            this.textEdit1.Visible = false;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(16, 697);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(1456, 95);
            this.txtLog.TabIndex = 15;
            this.txtLog.Visible = false;
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(459, 235);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(593, 407);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 843);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private DevExpress.XtraBars.BarButtonItem btnInsertItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnViewTransaction;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem addEmployee;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
    }
}


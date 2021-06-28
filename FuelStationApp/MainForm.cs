﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStationApp {
    public partial class MainForm : Form {

        private SqlConnection _SqlConnection;
        private DataSet _MasterData = new DataSet();

        public MainForm() {
            InitializeComponent();
        }

        private void ConnectWithDB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            SqlConnect();
        }

        private void SqlConnect() {
            
            _SqlConnection = new SqlConnection(textEdit1.Text);
            _SqlConnection.Open();

            // log
           AppendLog("Connenction State", _SqlConnection.State);
        }

        private void AppendLog(string name, object message) {
            txtLog.AppendText(string.Format("{0}={1}{2}", name, message, Environment.NewLine));
        }

        private void viewCustomersData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
           
            gridControl1.DataSource = _MasterData.Tables[0];
            //gridControl1.DataMember = _MasterData.Tables[0].TableName;
            gridControl1.Refresh();
            

        }

        private void getCustomersData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {

                SqlDataAdapter adapter = new SqlDataAdapter("select *  from Customers", _SqlConnection);
                adapter.Fill(_MasterData);

                // log
                AppendLog("Data Set Filled", "OK");
            }
            catch (Exception ex) {
                AppendLog("Exception", ex.Message);
            }
        }

        private void getEmployeesData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                
                SqlDataAdapter adapter = new SqlDataAdapter("select *  from Employees", _SqlConnection);
                adapter.Fill(_MasterData);

                // log
                AppendLog("Data Set Filled", "OK");
            }
            catch (Exception ex) {
                AppendLog("Exception", ex.Message);
            }
        }

        private void viewEmloyeesData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
           
            gridControl1.DataSource = _MasterData.Tables[0];
            gridControl1.Refresh();
            gridView1.OptionsView.ShowGroupPanel = false;

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

            // gridControl1.DataSource = null;
            // _MasterData.Tables[0].Clear();
            //gridControl1.DataSource = _MasterData.Tables[0];

            _MasterData.Tables[0].Clear();
            gridView1.Columns.Clear();
            gridControl1.DataSource = null;
            gridControl1.Refresh();


        }
      


    }
    
}
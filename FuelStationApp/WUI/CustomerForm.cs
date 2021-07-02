using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuelStationApp.Impl;
using FuelStationApp.Properties;

namespace FuelStationApp.WUI {
    public partial class CustomerForm : Form {
        public SqlConnection Connection { get; set; }

        private DataSet _MasterData = new DataSet();
        private DataSet _MasterDataOld = new DataSet();
        public CustomerForm() {
            InitializeComponent();
        }

        void PopulateDataGridView() {
            try {
                Connection.Open();
                string MyQuery = "SELECT * FROM Customers";
                SqlDataAdapter data = new SqlDataAdapter(MyQuery, Connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(data);
                var dataset = new DataSet();
                data.Fill(dataset);
                gridCustomers.DataSource = dataset.Tables[0];
                Connection.Close();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

   
        private void btnAdd_Click(object sender, EventArgs e) {
            AddCustomer();
            PopulateDataGridView();

        }

        private void gridCustomers_Click(object sender, EventArgs e) {

        }

        private void CustomerForm_Load(object sender, EventArgs e) {
            //PopulateDataGridView();
           // ResetFields();
        }

        public void AddCustomer() {
            string customerName = Convert.ToString(ctrlName.EditValue);
            string customerSurname = Convert.ToString(ctrlSurname.EditValue);
            string customerCardNumber = Convert.ToString(ctrlCardNumber.EditValue);


            Customer newCustomer = new Customer(customerName, customerSurname, customerCardNumber);

            if (!string.IsNullOrWhiteSpace(customerName) && !string.IsNullOrWhiteSpace(customerSurname) && !string.IsNullOrWhiteSpace(customerCardNumber)){

                SqlCommand cmd = new SqlCommand("INSERT INTO Customers (ID, Name, Surname, CardNumber) VALUES (NEWID(), '" + newCustomer.Name + "', '" + newCustomer.Surname + "', '" + newCustomer.CardNumber + "')", Connection);
                Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Items Succesfully Added");
                Connection.Close();
                PopulateDataGridView();
            }
            else {

                MessageBox.Show("Please fill all fields with valid values!");

            }
            
        }

        private void ResetFields() {
            ctrlName.Text = String.Empty;
            ctrlSurname.Text = String.Empty;
            ctrlCardNumber.Text = String.Empty;
        }

        private void btndelete_Click(object sender, EventArgs e) {
            DeleteCustomer();
        }
        private void DeleteCustomer() {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) {

                SqlCommand cmd = new SqlCommand(string.Format(Resources.DeleteCustomer, Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID"))), Connection);
                Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Record Succesfully Deleted!");
                Connection.Close();
                PopulateDataGridView();
                ResetFields();
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e) {
            EditCustomer();
          
            // UpdateEntry("ID");
        }

        private void EditCustomer() {
            try {
                Connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Customers SET Name='" + ctrlName.Text + "',Surname='" + ctrlSurname.Text + "' WHERE CardNumber='" + ctrlCardNumber.Text + "'", Connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Updated");
                Connection.Close();
                PopulateDataGridView();
                ResetFields();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e) {
            PopulateDataGridView();
            ResetFields();
        }

        private void btncancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void UpdateEntry(string primaryKey) {

            List<string> sqlCommands = new List<string>();

            //var c = _MasterData.Tables[0].GetChanges();

            bool hasChanges = _MasterData.HasChanges();
            if (!hasChanges) {
                return;
            }

            foreach (DataRow row in _MasterData.Tables[0].Rows) {

                string sql = string.Empty;
                string sqlSet = string.Empty;

                List<string> sqlSetLines = new List<string>();
                List<string> sqlWhereLines = new List<string>();

                DataRow rowOld = _MasterDataOld.Tables[0].Select("ID = " + row[primaryKey])[0];


                //if (row.RowState == DataRowState.Modified) { 

                //}

                foreach (DataColumn column in _MasterData.Tables[0].Columns) {

                    if (column.ColumnName == primaryKey) {
                        ComposeQueryField(sqlWhereLines, column.ColumnName, row[column]);
                    }
                    else {

                        if (row[column.ColumnName].ToString() != rowOld[column.ColumnName].ToString()) {

                            ComposeQueryField(sqlSetLines, column.ColumnName, row[column]);
                        }
                    }
                }

                sqlSet = string.Join(",", sqlSetLines);

                if (sqlSetLines.Count > 0) {
                    sql = "UPDATE " + _MasterData.Tables[0].TableName + " SET " + sqlSet + " WHERE " + string.Join(",", sqlWhereLines);
                    sqlCommands.Add(sql);

                }

              
            }

        }

        private void ComposeQueryField(List<string> sqlLine, string columnName, object value) {

            switch (value.GetType().Name) {
                case "Guid":
                case "String":
                    sqlLine.Add(string.Format("{0}='{1}'", columnName, value));
                    break;
               
                   

                case "Int32":
                case "Int64":
                    sqlLine.Add(string.Format("{0}={1}", columnName, value));
                    break;

                case "DateTime":
                    string datePart = Convert.ToDateTime(value).ToString("yyyyMMdd");
                    sqlLine.Add(string.Format("{0}='{1}'", columnName, datePart));
                    break;

                case "Decimal":

                    // decimal provider , .

                    string decimalPart = Convert.ToDecimal(value).ToString().Replace(',', '.');

                    sqlLine.Add(string.Format("{0}={1}", columnName, decimalPart));
                    break;
            }



        }

        private void btnSave_Click(object sender, EventArgs e) {
           
        }
    }

}

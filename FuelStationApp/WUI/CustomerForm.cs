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

          


                SqlCommand cmd = new SqlCommand("INSERT INTO Customers (ID, Name, Surname, CardNumber) VALUES (NEWID(), '" + newCustomer.Name + "', '" + newCustomer.Surname + "', '" + newCustomer.CardNumber +  "')", Connection);
                Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Items Succesfully Added");
                Connection.Close();
                PopulateDataGridView();
          
            
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
    }
  
}
